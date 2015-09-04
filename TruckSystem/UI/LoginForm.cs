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
using DevExpress.XtraSplashScreen;
using TruckSystem.Utils;
using TruckSystem.UI.SplashScreens;
using TruckSystem.UI.Utils;

namespace TruckSystem.UI
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            tfCPF.Focus();
            tfCPF.SelectAll();

            if (Environment.MachineName == "CADORE-NOTE")
            {
                tfCPF.Text = "050.425.459-64";
                tfPassword.Text = "cadore";
            }               

            SplashScreenManager.CloseForm(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
            login();
        }

        private void login()
        {
            try
            {
                user s = user.SingleOrDefault("WHERE cpf=@0 AND password=@1 AND inactive=FALSE",
                tfCPF.EditValue, Util.Encrypt(tfPassword.Text));
                if (s != null)
                {
                    Singleton.setUser(s);
                    saveLogin(s);
                    SplashScreenManager.ShowForm(null, typeof(SplashScreenForm), false, false, false);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Login ou senha incorretos, ou usuário inativo.\nPor favor verifique!");
                    tfPassword.Text = "";
                    tfCPF.Focus();
                    tfCPF.SelectAll();
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            finally
            {
                SplashScreenManager.CloseForm(false);                
            }
        }

        private void saveLogin(user s)
        {
            try
            {
                logins l = new logins()
                {
                    user_id = s.id,
                    date = user.Now(),
                    host = Environment.MachineName,
                    local_ip = Util.getInternalIp(),
                    external_ip = Util.getExternalIp()
                };
                l.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnExit_Click(sender, e);
        }

        private void tfCPF_KeyUp(object sender, KeyEventArgs e)
        {
            string cpf = Util.RemoveSpecialCharacters(tfCPF.EditValue.ToString());
            if (cpf.Length == 11)
                tfPassword.Focus();
        }
    }
}