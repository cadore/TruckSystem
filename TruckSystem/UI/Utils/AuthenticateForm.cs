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
using TruckSystem.Utils;
using DevExpress.XtraSplashScreen;
using TruckSystem.UI.SplashScreens;

namespace TruckSystem.UI.Utils
{
    public partial class AuthenticateForm : DevExpress.XtraEditors.XtraForm
    {
        public bool AdminIsRequired = false;
        public bool Authenticate = false;
        public user us = Singleton.getUser();

        public AuthenticateForm(bool _AdminIsRequired)
        {            
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            AdminIsRequired = _AdminIsRequired;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Authenticate = false;
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            user s = user.SingleOrDefault("WHERE cpf=@0 AND password=@1 AND inactive=FALSE AND admin=TRUE",
                us.cpf, Util.Encrypt(tfPassword.Text));
            if (s != null)
            {
                Singleton.setUser(s);
                SplashScreenManager.ShowForm(null, typeof(SplashScreenForm), false, false, false);
                this.Authenticate = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Login ou senha incorretos, ou usuário inativo.\nPor favor verifique!");
                tfPassword.SelectAll();
                tfPassword.Focus();
                return;
            }
        }

        private void AuthenticateForm_Shown(object sender, EventArgs e)
        {
            if (AdminIsRequired && !us.admin)
            {
                XtraMessageBox.Show("Para realizar esta operação você precisa ser um Administrador.");
                this.Authenticate = false;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void AuthenticateForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);
        }
    }
}