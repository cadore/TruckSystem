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
using TruckSystem.Utils;
using DevExpress.XtraSplashScreen;
using TruckSystem.UI.SplashScreens;

namespace TruckSystem.UI.Customer
{
    public partial class CustomerForm : TruckSystem.UI.Utils.UserControlUtil
    {
        
        public CustomerForm(customer c)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            bdgStates.DataSource = state.Fetch("ORDER BY symbol");            
            address d;
            if (c == null)
                IsNew = true;

            if (IsNew)
            {
                c = new customer();
                d = new address();
            }
            else
            {
                d = address.SingleOrDefault(c.address_id);
                tfCnpj.Properties.ReadOnly = true;
                tfIE.Properties.ReadOnly = true;
                rgType.Properties.ReadOnly = true;
                if (c.inactive)
                {
                    pnData.Enabled = false;
                    pnAddress.Enabled = false;
                }                    
            }
            bdgCustomer.DataSource = c;
            bdgAddress.DataSource = d;
        }

        public void loadFromCnpj(customer c, address d)
        {
            rgType.EditValue = c.type;
            bdgCustomer.DataSource = c;
            bdgAddress.DataSource = d;
            IsNew = true;
            subPnData.Enabled = true;
            pnAddress.Enabled = true;
        }

        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validations.ValidatorCPFCNPJ validatorCPFCNPJ1 = new Validations.ValidatorCPFCNPJ();
            subPnData.Enabled = false;
            pnAddress.Enabled = false;
            int t = Convert.ToInt32(rgType.EditValue);
            if (t == 0)
            {
                lbCNPJ.Text = "CNPJ:";
                lbCorporateName.Text = "Razão Social:";
                lbFantasyName.Text = "Nome Fantasia:";
                lbIE.Text = "IE:";

                tfCnpj.Properties.Mask.EditMask = "00.000.000/0000-00";
                if (validatorCPFCNPJ1 != null)
                    validatorCPFCNPJ1.ErrorText = "O CNPJ informado é inválido.";

                tfManager.Enabled = true;
                tfDocumentManager.Enabled = true;
                tfPhoneManager.Enabled = true;
            }
            else if (t == 1)
            {
                lbCNPJ.Text = "CPF:";
                lbCorporateName.Text = "Nome:";
                lbFantasyName.Text = "Sobrenome:";
                lbIE.Text = "RG/IE:";
                
                if (validatorCPFCNPJ1 != null)
                    validatorCPFCNPJ1.ErrorText = "O CPF informado é inválido.";
                tfCnpj.Properties.Mask.EditMask = "000.000.000-00";

                tfManager.Enabled = false;
                tfDocumentManager.Enabled = false;
                tfPhoneManager.Enabled = false;
            }

            tfCnpj.EditValue = null;
            tfIE.EditValue = null;
            tfCorporateName.EditValue = null;
            tfFantasyName.EditValue = null;

            tfCnpj.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            subPnData.Enabled = true;
            pnAddress.Enabled = true;

            this.validator.SetValidationRule(this.tfCnpj, validatorCPFCNPJ1);

            customer c = ((customer)bdgCustomer.Current);
            c.manager = "";
            c.document_manager = "";
            c.contact_manager = "";
            bdgCustomer.DataSource = c;

            tfCnpj.Focus();
            tfCnpj.SelectAll();
        }

        private void cbStateAddress_EditValueChanged(object sender, EventArgs e)
        {
            if(cbStateAddress.EditValue != null)
                bdgCity.DataSource = city.Fetch("WHERE state_id=@0", cbStateAddress.EditValue);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            SplashScreenManager.ShowForm(desk, typeof(PleaseWaitForm), false, false, false);
            try
            {
                using (var scope = customer.repo.GetTransaction())
                {
                    customer c = (customer)bdgCustomer.Current;
                    address d = (address)bdgAddress.Current;
                    if (IsNew)
                    {
                        c.registred_by = Singleton.getUser().id;
                        c.registred_at = customer.Now();
                        if (!Util.RemoveSpecialCharacters(c.document).Equals("00000000000"))
                        {
                            if (!Validations.Unique.DocumentCustomerIsUnique(c))
                            {
                                XtraMessageBox.Show(String.Format("O CNPJ/CPF informado ja consta cadastrado, verifique!"));
                                return;
                            }
                        }
                    }                        
                    d.Save();
                    c.address_id = d.id;
                    c.Save();
                    tfId.EditValue = c.id;
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                customer.repo.AbortTransaction();
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
                if (this.MessageToSave("Cliente"))
                    desk.AddTabAndCloseCurrent(new CustomerForm(null), "Novo cliente", false);
            }      
            
        }
    }
}
