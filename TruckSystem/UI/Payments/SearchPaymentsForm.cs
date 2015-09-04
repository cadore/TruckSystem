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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //try
            //{
                SplashScreenManager.ShowForm(desk, typeof(PleaseWaitForm), false, false, false);

                string sql = "";
                if (!String.IsNullOrEmpty(tfDescription.Text) 
                    || Convert.ToInt64(cbCustomer.EditValue) > 0 
                    || Convert.ToInt64(cbTruck.EditValue) > 0 
                    || (tfStartDateExpiration.EditValue != null && tfEndDateExpiration.EditValue != null)
                    || (tfStartDatePaid.EditValue != null && tfEndDatePaid.EditValue != null)
                    || rgPaid.EditValue != null)
                    sql = "WHERE";

                sql += " ORDER BY expiration_date, paid_date, paid";

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
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            //}
            //finally
            //{
                SplashScreenManager.CloseForm(false);
           // }
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
