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
        public NewDepositForm(deposits _d)
        {
            InitializeComponent();
            if(_d == null)
                _d = new deposits() { type = -1 };
            bdgDeposit.DataSource = _d;
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