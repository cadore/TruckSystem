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
using TruckSystem.FileManager.UI;

namespace TruckSystem.UI.Business
{
    public partial class BusinessForm : DevExpress.XtraEditors.XtraForm
    {
        public BusinessForm(business b)
        {
            InitializeComponent();
            if (b == null)
                b = new business();
            bdgBusiness.DataSource = b;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            FileManagerForm fm = new FileManagerForm(Enums.TypePath.business, ((business)bdgBusiness.Current).id);
            fm.ShowDialog();
        }
    }
}