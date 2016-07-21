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

namespace TruckSystem.Mail.UI
{
    public partial class ConfigureMailForm : DevExpress.XtraEditors.XtraForm
    {
        public ConfigureMailForm()
        {
            InitializeComponent();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            FileManagerForm fmf = new FileManagerForm(Enums.TypePath.mail, 0);
            fmf.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}