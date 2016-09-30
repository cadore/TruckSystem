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
            search();
        }

        private void tfSearch_EditValueChanged(object sender, EventArgs e)
        {
            search();
        }

        private void search()
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
            if (!Singleton.autenticateAdmin())
                return;

            FindNewBusiness fnb = new FindNewBusiness();
            DialogResult fnb_rs = fnb.ShowDialog();
            if (fnb_rs == DialogResult.OK)
            {
                search();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Para executar esta ação entre em contato com a equipe técnica.", "Atenção");
        }
    }
}