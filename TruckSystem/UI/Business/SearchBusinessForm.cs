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

namespace TruckSystem.UI.Business
{
    public partial class SearchBusinessForm : DevExpress.XtraEditors.XtraForm
    {
        public SearchBusinessForm()
        {
            InitializeComponent();
        }

        private void tfSearch_EditValueChanged(object sender, EventArgs e)
        {
            if (tfSearch.Text.Trim().Length >= 3)
            {

                bdgBusiness.DataSource = business.Fetch(String.Format("SELECT * FROM business WHERE corporate_name ILIKE '{0}'" +
                                                                        " UNION SELECT * FROM business WHERE fantasy_name ILIKE '{0}'",
                    business.Concat(tfSearch.Text)));
            }
            else if (tfSearch.Text.Trim().Length == 0)
                bdgBusiness.DataSource = business.Fetch("");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            business b = ((business)bdgBusiness.Current);
            if (b != null)
            {
                BusinessForm bf = new BusinessForm(b);
                if (bf.ShowDialog() == DialogResult.OK)
                {
                    bdgBusiness.DataSource = business.Fetch("");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}