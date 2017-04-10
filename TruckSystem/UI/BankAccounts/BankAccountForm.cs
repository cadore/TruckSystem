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
using TruckSystem.Utils;

namespace TruckSystem.UI.BankAccounts
{
    public partial class BankAccountForm : DevExpress.XtraEditors.XtraForm
    {
        public BankAccountForm(bank_account bc)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            bdgBanks.DataSource = banks.Fetch("ORDER BY name");
            bdgCustomers.DataSource = customer.Fetch("ORDER BY corporate_name");

            if (bc == null)
            {
                bc = new bank_account() { type = -1 };
            }
            else
            {                
                /*if (Util.RemoveSpecialCharacters(bc.document).Length == 11)
                    rgTypeHolder.EditValue = "cpf";
                else
                    rgTypeHolder.EditValue = "cnpj";
                rgType_SelectedIndexChanged(null, null);*/
            }
            bdgBankAccount.DataSource = bc;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            try
            {
                bank_account bc = (bank_account)bdgBankAccount.Current;
                if (bc.id == 0)
                {
                    bc.registred_at = bank_account.Now();
                    bc.registred_by = Singleton.getUser().id;
                }
                bc.Save();
                XtraMessageBox.Show("Conta Bancária salva com sucesso!");
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                this.DialogResult = DialogResult.Abort;
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                this.Close();
            }
        }

        private void cbCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if (cbCustomer.EditValue != null && Convert.ToInt32(cbCustomer.EditValue) > 0)
            {
                customer c = customer.SingleOrDefault(cbCustomer.EditValue);
                tfDocument.Text = c.document;
                //((customer)bdgBankAccount.Current).document = c.document;
            }
        }
    }
}