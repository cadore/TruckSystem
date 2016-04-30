using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckSystem.UI.Reports.Freights;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using TruckSystem.Models.Reports;
using TruckSystem.UI.SplashScreens;
using DevExpress.XtraEditors.DXErrorProvider;

namespace TruckSystem.UI.Truck.Reports
{
    public partial class ChooseTruckFreightsReportForm : DevExpress.XtraEditors.XtraForm
    {
        public ChooseTruckFreightsReportForm()
        {
            InitializeComponent();
            bdgTruck.DataSource = truck.Fetch("");
            bdgDrivers.DataSource = driver.Fetch("");
            cbTruck.Focus();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {            
            if (!validator.Validate())
                return;

            List<freight> llf = null;
            truck _truck = null;
            driver _driver = null;

            long truck_id = Convert.ToInt64(cbTruck.EditValue);
            long driver_id = Convert.ToInt64(cbDriver.EditValue);
            DateTime start = dtStart.DateTime;
            DateTime end = dtEnd.DateTime;

            bool isTruck = ckTruck.Checked;

            if(isTruck)
            {
                _truck = truck.SingleOrDefault(truck_id);
                llf = freight.Fetch(String.Format("WHERE truck_id={0} AND start BETWEEN '{1:yyyy-MM-dd}' AND '{2:yyyy-MM-dd}' ORDER BY start",
                    _truck.id, start, end));
                _driver = driver.SingleOrDefault(_truck.driver_id);
            }
            else if (ckDriver.Checked)
            {
                driver dri = driver.SingleOrDefault(driver_id);
                _truck = truck.SingleOrDefault("WHERE driver_id=@0", driver_id);
                llf = freight.Fetch(String.Format("WHERE driver_id={0} AND start BETWEEN '{1:yyyy-MM-dd}' AND '{2:yyyy-MM-dd}' ORDER BY start",
                    dri.id, start, end));
                _driver = dri;
                if (_truck == null)
                    _truck = new truck();
            }

            if (llf.Count <= 0)
            {
                XtraMessageBox.Show("Nenhum resultado encontrado para o período informado!");
                return;
            }

            decimal value_gross = 0;
            SplashScreenManager.ShowForm(this, typeof(PleaseWaitForm), false, false, false);
            trailer t1 = new trailer();
            trailer t2 = new trailer();
            trailer t3 = new trailer();
            if (_truck.id > 0)
            {
                t1 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", _truck.id, 1);
                t2 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", _truck.id, 2);
                t3 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", _truck.id, 3);
            }
            FreightsByTruckModel fm = new FreightsByTruckModel()
            {
                emission_at = String.Format("Emitido em {0:dd/MM/yyyy HH:mm}", freight.Now()),
                reference = String.Format("Período de {0:dd/MM/yyyy} à {1:dd/MM/yyyy}", start, end),
                signature = "Emitido por CadoreTecnologia",
                truck = String.Format("{0} - {1}{2}{3}",
                _truck.board, (t1 != null ? t1.board : ""), (t2 != null ? "/" + t2.board : ""), (t3 != null ? "/" + t3.board : "")),
                driver = _driver.full_name
            };

            if (_truck.id <= 0 && (t1.id <= 0) && (t2.id <= 0) && (t3.id <= 0))
            {
                fm.truck = "Motorista não cadastrado para nenhum veículo.";
                if (_driver.inactive)
                    fm.truck += " Motorista inativo.";
            }

            List<ListFreights> lf = new List<ListFreights>();
            foreach (freight f in llf)
            {
                decimal value_fueleds = 0, value_outputs = 0;
                List<ListFueleds> lfueled = new List<ListFueleds>();
                List<fueled> llfueled = fueled.Fetch("WHERE freight_id = @0", f.id);
                foreach (fueled fu in llfueled)
                {
                    value_fueleds += fu.total;
                    lfueled.Add(new ListFueleds()
                    {
                        date = Convert.ToDateTime(fu.date),
                        liters = fu.liters,
                        discont = fu.discount,
                        value_liters = fu.value_liters,
                        value_total = fu.total,
                        gas_station = customer.SingleOrDefault(fu.gas_station_id).corporate_name
                    });
                }

                List<ListOutputs> loutputs = new List<ListOutputs>();
                List<output> lloutputs = output.Fetch("WHERE freight_id = @0", f.id);
                foreach (output o in lloutputs)
                {
                    value_outputs += o.value;
                    loutputs.Add(new ListOutputs()
                    {
                        date = Convert.ToDateTime(o.date),
                        description = o.description,
                        value = o.value,
                        customer = customer.SingleOrDefault(o.customer_id).corporate_name
                    });
                }

                lf.Add(new ListFreights()
                {
                    comission = f.value_comission,
                    date = Convert.ToDateTime(f.start),
                    id = f.id,
                    listFueleds = lfueled,
                    listOutputs = loutputs,
                    driver = isTruck ? driver.SingleOrDefault(f.driver_id).full_name : truck.SingleOrDefault(f.truck_id).board,
                    outputs = value_outputs,
                    fueleds = value_fueleds,
                    product = f.product,
                    value_ton = f.value_ton,
                    gross = (f.value_ton * f.weight),
                    liquid = ((f.value_ton * f.weight) - (f.value_comission + value_fueleds + value_outputs))
                });
                value_gross += (f.value_ton * f.weight);
            }
            fm.gross = value_gross;
            fm.listFreights = lf;

            FreightsByTruckReport report = new FreightsByTruckReport();
            report.bdgFreigths.DataSource = fm;
            report.list.Value = isTruck ? "Motorista" : "Placa";
            report.start_page.Value = isTruck ? "Veículo" : "Motorista";
            ReportPrintTool tool = new ReportPrintTool(report);
            SplashScreenManager.CloseForm(false);
            tool.ShowRibbonPreviewDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckCheckedChanged(object sender, EventArgs e)
        {
            dtStart.Enabled = true;
            dtEnd.Enabled = true;
            ConditionValidationRule cvr = new ConditionValidationRule();
            int i = Convert.ToInt32(((RadioButton)sender).Tag);
            switch (i)
            {
                case 0:
                    //ckDriver.Checked = false;
                    cbTruck.Properties.ReadOnly = false;
                    cbDriver.Properties.ReadOnly = true;
                    cbDriver.EditValue = 0;
                    cbTruck.EditValue = 0;
                    cbTruck.Focus();
                    cvr.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
                    cvr.ErrorText = "Informe o Veículo";
                    cvr.Value1 = ((long)(0));
                    this.validator.SetValidationRule(this.cbTruck, cvr);
                    this.validator.SetValidationRule(this.cbDriver, null);
                    break;

                case 1:
                    //ckTruck.Checked = false;
                    cbTruck.Properties.ReadOnly = true;
                    cbDriver.Properties.ReadOnly = false;
                    cbDriver.EditValue = 0;
                    cbTruck.EditValue = 0;
                    cbDriver.Focus();
                    cvr.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
                    cvr.ErrorText = "Informe o Motorista";
                    cvr.Value1 = ((long)(0));
                    this.validator.SetValidationRule(this.cbDriver, cvr);
                    this.validator.SetValidationRule(this.cbTruck, null);
                    break;
            }
        }
    }
}