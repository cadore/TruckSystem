using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PetaPoco;
using DevExpress.XtraSplashScreen;
using TruckSystem.UI.SplashScreens;

namespace TruckSystem.UI.Freights
{
    public partial class SearchFreightsForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public SearchFreightsForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            bdgTruck.DataSource = truck.Fetch("");
        }

        void searchFreights()
        {
            try
            {
                SplashScreenManager.ShowForm(desk, typeof(PleaseWaitForm), false, false, false);
                List<freight> listF = new List<freight>();
                string st = "";

                if (Convert.ToInt64(tfId.EditValue) > 0 || Convert.ToInt64(cbTruck.EditValue) > 0
                        || Convert.ToInt32(tfNumberNote.EditValue) > 0 || (tfStart.EditValue != null && tfEnd.EditValue != null))
                    st += "WHERE";
                if (Convert.ToInt64(tfId.EditValue) > 0)
                {
                    st += String.Format(" id={0}", tfId.EditValue);                    
                }
                
                if (Convert.ToInt64(cbTruck.EditValue) > 0)
                {
                    if (Convert.ToInt64(tfId.EditValue) > 0)
                        st += " AND";
                    st += String.Format(" truck_id={0}", cbTruck.EditValue);
                }

                if (Convert.ToInt64(tfNumberNote.EditValue) > 0)
                {
                    if (Convert.ToInt64(tfId.EditValue) > 0 || Convert.ToInt64(cbTruck.EditValue) > 0)
                        st += " AND";
                    st += String.Format(" number_note={0}", tfNumberNote.EditValue);
                }

                if (tfStart.EditValue != null && tfEnd.EditValue != null)
                {
                    if (Convert.ToInt64(tfId.EditValue) > 0 || Convert.ToInt64(cbTruck.EditValue) > 0 
                        || Convert.ToInt32(tfNumberNote.EditValue) > 0)
                        st += " AND";
                    st += String.Format(" start BETWEEN to_date('{0:yyyy-MM-dd}', 'yyyy-MM-dd') AND to_date('{1:yyyy-MM-dd}', 'yyyy-MM-dd')",
                        tfStart.DateTime, tfEnd.DateTime);
                }
                st += " ORDER BY start DESC";
                listF = freight.Fetch(st);
                
                for (int i = 0; i < listF.Count; i++)
                {
                    freight f = listF[i];
                    customer cs = customer.SingleOrDefault(f.company_source);
                    city cacs = city.SingleOrDefault(address.SingleOrDefault(cs.address_id).city_id);
                    f.company_source_name = String.Format("{0}/{1}", cacs.name, cs.corporate_name);
                    customer cd = customer.SingleOrDefault(f.company_destination);
                    city cacd = city.SingleOrDefault(address.SingleOrDefault(cd.address_id).city_id);
                    f.company_destination_name = String.Format("{0}/{1}", cacd.name, cd.corporate_name);
                    f.truck_board = truck.SingleOrDefault(f.truck_id).board;


                    decimal gross = ((f.weight * f.value_ton) + totalStays(f.id));
                    decimal fueleds = totalFueleds(f.id);
                    decimal outputs = totalOutputs(f.id);
                    f.total = (gross - f.value_comission) - (fueleds + outputs);
                    listF[i] = f;
                }
                bdgFreights.DataSource = listF;
                SplashScreenManager.CloseForm(false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (bdgFreights.Current != null)
            {
                FreightForm ff = new FreightForm((freight)bdgFreights.Current);
                desk.AddTab(ff, "Edição de Frete", true);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchFreights();
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchFreights();
        }
        decimal totalFueleds(long freight_id)
        {
            try
            {
                var result = TruckSystemRepo.GetInstance().ExecuteScalar<string>("SELECT SUM(total) FROM fueleds WHERE freight_id=@0",
                freight_id);
                if (result.Equals(DBNull.Value) || String.IsNullOrEmpty(result))
                    return 0;
                else
                    return Convert.ToDecimal(result);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            return 0;
        }

        decimal totalOutputs(long freight_id)
        {
            try
            {
                var result = TruckSystemRepo.GetInstance().ExecuteScalar<string>("SELECT SUM(value) FROM outputs WHERE freight_id=@0",
                freight_id);
                if (result.Equals(DBNull.Value) || String.IsNullOrEmpty(result))
                    return 0;
                else
                    return Convert.ToDecimal(result);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            return 0;
        }
        decimal totalStays(long freight_id)
        {
            try
            {
                var result = TruckSystemRepo.GetInstance().ExecuteScalar<string>("SELECT SUM(total) FROM stays WHERE freight_id=@0",
                freight_id);
                if (result.Equals(DBNull.Value) || String.IsNullOrEmpty(result))
                    return 0;
                else
                    return Convert.ToDecimal(result);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            return 0;
        }
    }
}
