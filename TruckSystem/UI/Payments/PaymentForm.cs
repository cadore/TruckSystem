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
using DevExpress.XtraEditors.DXErrorProvider;
using TruckSystem.UI.Category;

namespace TruckSystem.UI.Payments
{
    public partial class PaymentForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public PaymentForm(payment p)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            if (p == null)
            {
                p = new payment();
                IsNew = true;
            }
            loadData();
            bdgPayment.DataSource = p;
        }

        private void loadData()
        {
            try
            {
                bdgCustomer.DataSource = customer.Fetch("");
                bdgTruck.DataSource = truck.Fetch("");
                bdgCategory.DataSource = category.Fetch("WHERE type=@0 ORDER BY name", (int)category.Categorys.Payment);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validate())
                return;
            try
            {                
                payment p = (payment)bdgPayment.Current;
                p.registred_at = payment.Now();
                p.registred_by = Singleton.getUser().id;
                p.Save();
                if (MessageToSave("Pagamento"))
                    desk.AddTabAndCloseCurrent(new PaymentForm(null), "Novo Pagamento", false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }       

        private void btnParcel_Click(object sender, EventArgs e)
        {
            /*if (!validate())
                return;
            ParcelPaymentForm ppf = new ParcelPaymentForm((payment)bdgPayment.Current);
            DialogResult rs = ppf.ShowDialog();
            if (rs == DialogResult.OK)
                if (MessageToSave("Pagamento"))
                    desk.AddTabAndCloseCurrent(new PaymentForm(null), "Novo Pagamento", false);*/
        }
        bool validate()
        {
            bool valid = true;
            if (!validator.Validate())
                valid = false;
            return valid;
        }
        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewCategoryForm ncf = new NewCategoryForm(category.Categorys.Payment);
            if (ncf.ShowDialog() == DialogResult.OK)
                loadData();
            else
                XtraMessageBox.Show("Categoria não cadastrada!");
        }
    }
}
