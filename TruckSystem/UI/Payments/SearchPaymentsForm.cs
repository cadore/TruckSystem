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
using DevExpress.XtraSplashScreen;
using TruckSystem.UI.SplashScreens;

namespace TruckSystem.UI.Payments
{
    public partial class SearchPaymentsForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public SearchPaymentsForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            bdgCustomers.DataSource = customer.Fetch("");
            bdgTrucks.DataSource = truck.Fetch("");
            rgPaid.EditValue = 2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(desk, typeof(PleaseWaitForm), false, false, false);

                int rg = Convert.ToInt32(rgPaid.EditValue);
                string sql = "";
                if (!String.IsNullOrEmpty(tfDescription.Text) 
                    || Convert.ToInt64(cbCustomer.EditValue) > 0 
                    || Convert.ToInt64(cbTruck.EditValue) > 0 
                    || (tfStartDateExpiration.EditValue != null && tfEndDateExpiration.EditValue != null)
                    || rg < 2)
                    sql = "WHERE";

                if (!String.IsNullOrEmpty(tfDescription.Text))
                    sql += String.Format(" description ILIKE '{0}'", payment.Concat(tfDescription.Text));

                if (Convert.ToInt64(cbCustomer.EditValue) > 0)
                {
                    if (!String.IsNullOrEmpty(tfDescription.Text))
                        sql += " AND";
                    sql += String.Format(" customer_id={0}", cbCustomer.EditValue);
                }

                if (Convert.ToInt64(cbTruck.EditValue) > 0)
                {
                    if (!String.IsNullOrEmpty(tfDescription.Text) || Convert.ToInt64(cbCustomer.EditValue) > 0)
                        sql += " AND";
                    sql += String.Format(" truck_id={0}", cbTruck.EditValue);
                }

                if (tfStartDateExpiration.EditValue != null && tfEndDateExpiration.EditValue != null)
                {
                    if (!String.IsNullOrEmpty(tfDescription.Text) || Convert.ToInt64(cbCustomer.EditValue) > 0 
                        || Convert.ToInt64(cbTruck.EditValue) > 0)
                        sql += " AND";
                    sql += String.Format(" expiration_date BETWEEN '{0:yyyy-MM-dd}' AND '{1:yyyy-MM-dd}'",
                        tfStartDateExpiration.DateTime, tfEndDateExpiration.DateTime);
                }

                if (rg < 2)
                {
                    if (!String.IsNullOrEmpty(tfDescription.Text) 
                    || Convert.ToInt64(cbCustomer.EditValue) > 0 
                    || Convert.ToInt64(cbTruck.EditValue) > 0 
                    || (tfStartDateExpiration.EditValue != null && tfEndDateExpiration.EditValue != null))
                        sql += " AND";
                    sql += String.Format(" paid={0}", rg == 0 ? false : true);
                }                    

                sql += " ORDER BY expiration_date, paid";

                Console.WriteLine(sql);
                List<payment> listP = payment.Fetch(sql);
                for (int i = 0; i < listP.Count; i++)
                {
                    payment p = listP[i];
                    if(p.customer_id > 0)
                        p.customer_name = customer.SingleOrDefault(p.customer_id).corporate_name;
                    if(p.truck_id > 0)
                        p.truck_board = truck.SingleOrDefault(p.truck_id).board;
                    listP[i] = p;
                }
                bdgPayments.DataSource = listP;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (bdgPayments.Current != null)
            {
                PaymentForm pf = new PaymentForm((payment)bdgPayments.Current);
                desk.AddTab(pf, "Novo Pagamento", true);
            }
        }
    }
}
