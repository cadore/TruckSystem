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

namespace TruckSystem.UI.Drivers
{
    public partial class SearchDriversForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public SearchDriversForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            rgTypeSearch.EditValue = "name";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (bdgDrivers.Current != null)
            {
                DriverForm df = new DriverForm((driver)bdgDrivers.Current);
                desk.AddTab(df, "Edição de Motorista", true);
            }            
        }

        private void rgTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tfSearch.EditValue = null;
            string st = rgTypeSearch.EditValue.ToString();
            if (st.Equals("name"))
            {
                lbTypeSearch.Text = "Nome Completo:";
                tfSearch.Properties.Mask.EditMask = "";
                tfSearch.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            }
            else if (st.Equals("cpf"))
            {
                lbTypeSearch.Text = "CPF:";
                tfSearch.Properties.Mask.EditMask = "000.000.000-00";
                tfSearch.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            }
            tfSearch.Focus();
            tfSearch.SelectAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<driver> listD = null;
            string st = rgTypeSearch.EditValue.ToString();
            if (st.Equals("name"))
            {
                listD = driver.Fetch("WHERE full_name ILIKE @0 ORDER BY full_name", driver.Concat(tfSearch.EditValue));
            }
            else if (st.Equals("cpf"))
            {
                listD = driver.Fetch("WHERE cpf=@0 ORDER BY full_name", tfSearch.EditValue);
            }
            bdgDrivers.DataSource = listD;

        }

        private void tfSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }
    }
}
