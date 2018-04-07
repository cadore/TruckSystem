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

namespace TruckSystem.UI.Customer
{
    public partial class SearchCustomersForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public SearchCustomersForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            rgSearch.EditValue = "name";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            customer c = (customer)bdgCustomer.Current;
            if (c != null)
            {
                CustomerForm cf = new CustomerForm(c);
                desk.AddTab(cf, "Edição de Cliente", true);
            }
        }

        private void rgSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tfSearch.Text = "";
            string t = rgSearch.EditValue.ToString();
            if (t.Equals("name"))
            {                
                tfSearch.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                tfSearch.Properties.Mask.EditMask = "";
            }
            else if (t.Equals("id"))
            {
                tfSearch.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                tfSearch.Properties.Mask.EditMask = "d";
            }
            else
            {
                tfSearch.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                tfSearch.Properties.Mask.EditMask = @"(\d{2}\.\d{3}\.\d{3}/\d{4}\-\d{2})|(\d{3}\.\d{3}\.\d{3}\-\d{2})";
            }
            tfSearch.Focus();
            tfSearch.SelectAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<customer> listC = new List<customer>();
            string t = rgSearch.EditValue.ToString();
            if (t.Equals("name"))
            {
                listC = customer.Fetch("SELECT * FROM customers WHERE corporate_name ILIKE @0"
                + " UNION SELECT * FROM customers WHERE fantasy_name ILIKE @0", customer.Concat(tfSearch.EditValue));
            }
            else if (t.Equals("id"))
            {
                listC = customer.Fetch("WHERE id=@0", tfSearch.EditValue);
            }
            else
            {
                listC = customer.Fetch("WHERE document=@0", tfSearch.EditValue);
            }
            bdgCustomer.DataSource = listC;
        }

        private void tfSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }
    }
}
