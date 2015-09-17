using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckSystem.UI.AccountsToPay
{
    public partial class AccountsToPayForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public AccountsToPayForm(accounts_to_pay atp)
        {
            InitializeComponent();
            if (atp == null)
            {
                atp = new accounts_to_pay();
                IsNew = true;
            }
            bdgCustomer.DataSource = customer.Fetch("ORDER BY corporate_name");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void Focus(object sender, EventArgs e)
        {
            TextEdit tf = (TextEdit)sender;
            tf.SelectAll();
            tf.Focus();
        }
    }
}
