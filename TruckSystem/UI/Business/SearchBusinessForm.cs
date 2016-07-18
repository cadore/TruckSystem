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
using TruckSystem.UI.Utils;

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

                bdgBusiness.DataSource = customer.Fetch(String.Format("SELECT * FROM customers WHERE corporate_name ILIKE '{0}' AND is_business = TRUE" +
                                                                        " UNION SELECT * FROM customers WHERE fantasy_name ILIKE '{0}' AND is_business = TRUE",
                    customer.Concat(tfSearch.Text)));
            }
            else if (tfSearch.Text.Trim().Length == 0)
                bdgBusiness.DataSource = customer.Fetch("WHERE is_business = TRUE");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            /*business b = ((business)bdgBusiness.Current);
            if (b != null)
            {
                BusinessForm bf = new BusinessForm(b);
                if (bf.ShowDialog() == DialogResult.OK)
                {
                    bdgBusiness.DataSource = business.Fetch("");
                }
            }*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AuthenticateForm af = new AuthenticateForm(true);
            DialogResult rs = af.ShowDialog();
            if (rs != DialogResult.OK && !af.Authenticate)
                return;

        }
    }
}