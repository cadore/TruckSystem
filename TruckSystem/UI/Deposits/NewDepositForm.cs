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

namespace TruckSystem.UI.Deposits
{
    public partial class NewDepositForm : DevExpress.XtraEditors.XtraForm
    {
        public deposits NewDeposit = null;
        public NewDepositForm(deposits _d, freight fre)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            loadModels();
            if(_d == null)
                _d = new deposits() { type = -1, freight_id = fre.id, truck_id = fre.truck_id, date = null };
            bdgDeposit.DataSource = _d;
        }

        private void loadModels()
        {
            bdgCustomer.DataSource = customer.Fetch("");
            List<bank_account> bc = bank_account.Fetch("");
            for (int i = 0; i < bc.Count; i++)
            {
                banks b = banks.SingleOrDefault(bc[i].bank_id);
                bc[i].account_name = String.Format("{0}-{1} / {2}-{3}", b.code, b.name, bc[i].agency, bc[i].account);
                bc[i].bank_name = b.name;
            }
            bdgBankAccounts.DataSource = bc;
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
            NewDeposit = (deposits)bdgDeposit.Current;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}