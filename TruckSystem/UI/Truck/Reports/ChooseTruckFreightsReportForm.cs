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

namespace TruckSystem.UI.Truck.Reports
{
    public partial class ChooseTruckFreightsReportForm : DevExpress.XtraEditors.XtraForm
    {
        public ChooseTruckFreightsReportForm()
        {
            InitializeComponent();
            bdgTruck.DataSource = truck.Fetch("");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;

            long truck_id = Convert.ToInt64(cbTruck.EditValue);
            DateTime start = dtStart.DateTime;
            DateTime end = dtEnd.DateTime;

            truck t = truck.SingleOrDefault(truck_id);
            List<freight> llf = freight.Fetch(String.Format("WHERE truck_id={0}AND start BETWEEN '{1:yyyy-MM-dd}' AND '{2:yyyy-MM-dd}' ORDER BY start",
                t.id, start, end));

            if (llf.Count <= 0)
            {
                XtraMessageBox.Show("Nenhum resultado encontrado para o período informado!");
                return;
            }

            decimal value_gross = 0;
            SplashScreenManager.ShowForm(this, typeof(PleaseWaitForm), false, false, false);
            trailer t1 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", t.id, 1);
            trailer t2 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", t.id, 2);
            trailer t3 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", t.id, 3);
            FreightsByTruckModel fm = new FreightsByTruckModel()
            {
                emission_at = String.Format("Emitido em {0:dd/MM/yyyy HH:mm}", freight.Now()),
                reference = String.Format("Período de {0:dd/MM/yyyy} à {1:dd/MM/yyyy}", start, end),
                signature = "Emitido por CadoreTecnologia",
                truck = String.Format("{0} - {1}{2}{3}",
                t.board, (t1 != null ? t1.board : ""), (t2 != null ? "/" + t2.board : ""), (t3 != null ? "/" + t3.board : "")),
                driver = driver.SingleOrDefault(t.driver_id).full_name
            };
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
                    driver = driver.SingleOrDefault(f.driver_id).full_name,
                    outputs = value_outputs,
                    fueleds = value_fueleds,
                    product = f.product,
                    value_ton = f.value_ton,
                    weight = f.weight,
                    liquid = ((f.value_ton * f.weight) - (f.value_comission + value_fueleds + value_outputs))
                });
                value_gross += (f.value_ton * f.weight);
            }
            fm.gross = value_gross;


            fm.listFreights = lf;
            FreightsByTruckReport report = new FreightsByTruckReport();
            report.bdgFreigths.DataSource = fm;
            ReportPrintTool tool = new ReportPrintTool(report);

            SplashScreenManager.CloseForm(false);

            tool.ShowRibbonPreviewDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}