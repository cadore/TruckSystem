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

namespace TruckSystem.UI.BankAccounts
{
    public partial class ManagerBankAccountsForm : DevExpress.XtraEditors.XtraForm
    {
        public ManagerBankAccountsForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            SearchAll();
        }

        private void SearchAll()
        {
            bdgBankAccounts.DataSource = bank_account.Fetch("");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (bdgBankAccounts.Current != null)
            {
                BankAccountForm baf = new BankAccountForm((bank_account)bdgBankAccounts.Current);
                DialogResult rs = baf.ShowDialog();
                if (rs == DialogResult.OK)
                    SearchAll();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BankAccountForm baf = new BankAccountForm(null);
            DialogResult rs = baf.ShowDialog();
            if (rs == DialogResult.OK)
                SearchAll();
        }
    }
}