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
using TruckSystem.FileManager;
using System.IO;
using TruckSystem.Utils;

namespace TruckSystem.Mail.UI
{
    public partial class ConfigureMailForm : DevExpress.XtraEditors.XtraForm
    {
        public ConfigureMailForm()
        {
            InitializeComponent();
            btnViewSignature.Visible = false;
            mails smt = mails.SingleOrDefault(1);
            if (smt == null)
                smt = new mails();
            else
            {
                smt.password = Util.Decrypt(smt.password);
            }
            bdgMail.DataSource = smt;            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validator.Validate())
                    return;
                mails sm = ((mails)bdgMail.Current);
                sm.password = Util.Encrypt(sm.password);
                sm.Save();
                SmtpMailUtil.LoadCfg();
                XtraMessageBox.Show("Configurações salvas com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocorreu um erro:\n\n" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewSignature_Click(object sender, EventArgs e)
        {
            
        }
    }
}