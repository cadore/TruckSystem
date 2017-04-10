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
            List<bank_account> ba = bank_account.Fetch("");
            for (int i = 0; i < ba.Count; i++)
            {
                banks b = banks.SingleOrDefault(ba[i].bank_id);
                customer c = customer.SingleOrDefault(ba[i].customer_id);
                ba[i].bank_name = b.name;
                ba[i].bank_number = b.code;
                ba[i].holder = c.corporate_name;
                ba[i].document = c.document;
            }
            bdgBankAccounts.DataSource = ba;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bank_account b = (bank_account)bdgBankAccounts.Current;
            if (b.id > 0)
                bank_account.Delete(b.id);

            bdgBankAccounts.RemoveCurrent();
        }
    }
}