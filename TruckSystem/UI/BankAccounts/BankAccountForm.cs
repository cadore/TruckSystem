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
            if (bc == null)
            {
                bc = new bank_account();
                rgType.EditValue = "cnpj";   
            }
            else
            {                
                if (Util.RemoveSpecialCharacters(bc.document).Length == 11)
                    rgType.EditValue = "cpf";
                else
                    rgType.EditValue = "cnpj";
                rgType_SelectedIndexChanged(null, null);
            }
            bdgBankAccount.DataSource = bc;
            tfNumber.Focus();
            tfNumber.SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tfDocument.EditValue = null;
            string st = rgType.EditValue.ToString();
            if (st.Equals("cnpj"))
            {
                tfDocument.Properties.Mask.EditMask = "00.000.000/0000-00";
                lbDocument.Text = "CNPJ:";
            }
            else
            {
                tfDocument.Properties.Mask.EditMask = "000.000.000-00";
                lbDocument.Text = "CPF:";
            }
            tfDocument.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            tfDocument.Focus();
            tfDocument.SelectAll();
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
    }
}