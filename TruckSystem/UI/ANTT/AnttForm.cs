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
using DevExpress.XtraSplashScreen;
using TruckSystem.UI.SplashScreens;
using TruckSystem.Utils;

namespace TruckSystem.UI.ANTT
{
    public partial class AnttForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public AnttForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            bdgCustomer.DataSource = customer.Fetch("ORDER BY id");
        }

        private void cbCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if(cbCustomer.EditValue != null)
            {                
                bdgState.DataSource = state.Fetch("ORDER BY symbol");
                antts ant = antts.SingleOrDefault("WHERE customer_id=@0", Convert.ToInt64(cbCustomer.EditValue));
                if (ant == null)
                    ant = new antts();
                bdgAntt.DataSource = ant;
                pnControls.Enabled = true;
                btnSave.Enabled = true;

                if (ant.id > 0)
                    IsNew = false;
                else
                    IsNew = true;
            }
            else
            {
                bdgAntt.DataSource = null;
                pnControls.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void cbUf_EditValueChanged(object sender, EventArgs e)
        {
            if (cbUf.EditValue != null)
                bdgCity.DataSource = city.Fetch("WHERE state_id=@0", cbUf.EditValue);
            else
                bdgCity.DataSource = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;

            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                antts an = (antts)bdgAntt.Current;
                an.customer_id = Convert.ToInt64(cbCustomer.EditValue);
                if (IsNew)
                    if (!Validations.Unique.NumberRntrcUnique(an))
                    {
                        antts a = antts.SingleOrDefault("WHERE rntrc=@0", an.rntrc);
                        customer c = customer.SingleOrDefault(a.customer_id);
                        SplashScreenManager.CloseForm(false);
                        XtraMessageBox.Show(String.Format("Rntrc já cadastrado!\nEm nome de {0} - {1}", c.corporate_name, c.document));
                        return;
                    }
                Console.WriteLine(an.customer_id);
                an.Save();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorre um erro:\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }

            if (this.MessageToSave("ANTT/RNTRC"))
                desk.AddTabAndCloseCurrent(new AnttForm(), "Gerenciar ANTT", false);
        }        
    }
}
