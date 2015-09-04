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

namespace TruckSystem.UI.Payments
{
    public partial class ParcelPaymentForm : DevExpress.XtraEditors.XtraForm
    {
        payment p;
        public ParcelPaymentForm(payment _p)
        {
            p = _p;
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            if (p != null)
            {
                if (!String.IsNullOrEmpty(p.guid))
                {
                    pnControlsGenerateParcels.Enabled = false;
                    bdgPayments.DataSource = payment.Fetch("WHERE guid=@0 AND expiration_date >= @1"
                    + " ORDER BY expiration_date", p.guid, String.Format("{0:yyyy-MM-dd}", payment.Now()));
                }
            }
        }

        private void btnGenereteParcels_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            bdgPayments.Clear();
            int qnt_parcels = Convert.ToInt32(tfQntParcels.EditValue);
            int days = Convert.ToInt32(tfDaysEntryParcels.EditValue);
            DateTime initialDate = Convert.ToDateTime(p.expiration_date);
            Console.WriteLine(initialDate);
            List<payment> listP = new List<payment>();
            for (int i = 0; i < qnt_parcels; i++)
            {
                payment pay = new payment() 
                { 
                    customer_id = p.customer_id, 
                    description = p.description, 
                    expiration_date = p.expiration_date, 
                    freight_id = p.freight_id, 
                    registred_by = p.registred_by, 
                    registred_at = p.registred_at, 
                    id = p.id, 
                    is_payment = p.is_payment, 
                    observation = p.observation, 
                    paid = p.paid, 
                    paid_date = p.paid_date, 
                    reason_expiration = p.reason_expiration, 
                    truck_id = p.truck_id, 
                    value = p.value, 
                    value_paid = p.value_paid
                };

                pay.description = pay.description + String.Format(" {0:d2}/{1:d2}", i + 1, qnt_parcels);
                pay.expiration_date = initialDate;
                listP.Add(pay);
                initialDate = initialDate.AddDays(days);
                Console.WriteLine(initialDate);
                pay = null;
            }

            foreach (payment pa in listP)
            {
                Console.WriteLine(pa.expiration_date + "/" + pa.description);
            }
            bdgPayments.DataSource = listP;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = payment.repo.GetTransaction())
                {
                    List<payment> listP = ((List<payment>)bdgPayments.DataSource);
                    string guid = NewGuid();

                    foreach (payment py in listP)
                    {
                        if (py.id == 0)
                        {
                            py.registred_at = payment.Now();
                            py.registred_by = Singleton.getUser().id;
                            py.guid = guid;
                        }                        
                        py.Save();
                    }
                    scope.Complete();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;
                payment.repo.AbortTransaction();
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }

        string NewGuid()
        {
            string guid = Guid.NewGuid().ToString().Replace("-", "");
            payment pa = payment.SingleOrDefault("WHERE guid=@0 LIMIT 1", guid);
            if (pa != null)
                NewGuid();
            return guid;
        }
    }
}