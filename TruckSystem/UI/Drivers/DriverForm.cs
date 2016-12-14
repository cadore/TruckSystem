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
using System.Text.RegularExpressions;
using System.IO;
using PetaPoco;
using TruckSystem.FileManager.UI;

namespace TruckSystem.UI.Drivers
{
    public partial class DriverForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public DriverForm(driver d)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            lbBirthday.Text = "";            
            bdgState.DataSource = state.Fetch("");
            address ad;
            if (d == null)
                IsNew = true;
            if (IsNew)
            {
                d = new driver() { birthday = null, admitted_at = null, dismissed_at = null, genre = -1 };
                ad = new address();
                btnFiles.Enabled = false;
            }
            else
            {
                ad = address.SingleOrDefault(d.address);
                tfCpf.Properties.ReadOnly = true;
                //tfNumberCnh.Properties.ReadOnly = true;

                if (d.inactive)
                {
                    pnGeneral.Enabled = false;
                    btnSave.Visible = false;
                }
            }
            bdgAddress.DataSource = ad;
            bdgDriver.DataSource = d;
            DateTime now = driver.Now();
            tfBirthday.Properties.MaxValue = now;
            tfAdmittedAt.Properties.MaxValue = now;
            tfDismissedAt.Properties.MaxValue = now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void cbStateAddress_EditValueChanged(object sender, EventArgs e)
        {
            bdgCity.DataSource = city.Fetch("WHERE state_id=@0", cbStateAddress.EditValue);
        }

        private void tfBirthday_EditValueChanged(object sender, EventArgs e)
        {
            int year = Dates.CalculateAge(driver.Now(), tfBirthday.DateTime);
            if (year < 0 || year > 100)
                year = 0;
            lbBirthday.Text = String.Format("{0:d} Anos", year);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            try
            {
                using (var scope = driver.repo.GetTransaction())
                {                    
                    driver dr = (driver)bdgDriver.Current;
                    address ad = (address)bdgAddress.Current;
                    if (Dates.CalculateAge(driver.Now(), tfBirthday.DateTime) < 18)
                    {
                        XtraMessageBox.Show("Idade incorreta, deve ter no mínimo 18 anos");
                        return;
                    }
                    SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                    if (IsNew)
                    {
                        dr.registred_at = driver.Now();
                        dr.registred_by = Singleton.getUser().id;
                        if (!Validations.Unique.CPFDriverIsUnique(dr))
                        {                         
                            XtraMessageBox.Show(String.Format("O CPF informado ja consta cadastrado, verifique!"));
                            tfCpf.Focus();
                            tfCpf.SelectAll();
                            return;
                        }
                        /*if (!Validations.Unique.CNHDriverIsUnique(dr))
                        {
                            XtraMessageBox.Show(String.Format("A CNH informada ja consta cadastrada, verifique!"));
                            tfNumberCnh.Focus();
                            tfNumberCnh.SelectAll();
                            return;
                        }*/
                         
                    }
                    DateTime min = DateTime.MinValue;
                    if (DateTime.TryParse(dr.dismissed_at.ToString(), out min))
                    {
                        DialogResult rs = XtraMessageBox.Show(String.Format("Confirma a demissão do Motorista?"),
                            "Cadore Tecnologia", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.No)
                            return;
                        dr.inactive = true;
                    }
                    else
                    {
                        dr.inactive = false;
                    }
                    ad.Save();
                    dr.address = ad.id;                    
                    dr.Save();
                    scope.Complete();
                    XtraMessageBox.Show(String.Format("Motorista {0} salvo com sucesso.", dr.full_name));
                    desk.AddTabAndCloseCurrent(new DriverForm(driver.SingleOrDefault(dr.id)), "Editar motorista", false);
                    //if (this.MessageToSave("Motorista"))
                      //  desk.AddTabAndCloseCurrent(new DriverForm(null), "Novo motorista", false);
                }                
            }
            catch (Exception ex)
            {
                driver.repo.AbortTransaction();
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        void transferfile(string file)
        {
            string raiz = @"\\Ct-server\hdcadore\teste_trucksystem\";

            FileInfo finfo = new FileInfo(file);

            File.Copy(file, raiz + "" + finfo.Name);
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            FileManagerForm fmf = new FileManagerForm(Enums.TypePath.drivers, ((driver)bdgDriver.Current).id);
            fmf.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            desk.AddTabAndCloseCurrent(new DriverForm(null), "Novo motorista", false);
        }

        private void btnFileCNH_Click(object sender, EventArgs e)
        {

        }

        private void cbCity_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchCEP_Click(object sender, EventArgs e)
        {
            if (!validatorSearchCEP.Validate())
                return;

            tfCep.SelectAll();

            try
            {
                if (Util.isConnectedWeb() && (tfCep.EditValue != null && !String.IsNullOrEmpty(tfCep.EditValue.ToString())))
                {
                    SplashScreenManager.ShowForm(desk, typeof(PleaseWaitForm), false, false, false);
                    WebCEP wcep = new WebCEP(tfCep.EditValue.ToString(), WebCEP.TypeCase.Upper);

                    ((address)bdgAddress.Current).state_id = 0;
                    cbStateAddress.EditValue = 0;
                    ((address)bdgAddress.Current).city_id = 0;
                    cbCity.EditValue = 0;
                    ((address)bdgAddress.Current).district = "";
                    tfDistrict.EditValue = "";
                    ((address)bdgAddress.Current).name = "";
                    tfAddress.EditValue = "";

                    if (wcep.RESULTADO == 0)
                    {
                        ((address)bdgAddress.Current).cep = "";
                        tfCep.EditValue = "";

                        SplashScreenManager.CloseForm(false);
                        XtraMessageBox.Show("O CEP informado não foi encontrado!\n"
                            + "Verifique e tente novamente ou informe manualmente.", "CADORE TECNOLOGIA");
                        return;
                    }
                    else
                    {
                        state s = state.SingleOrDefault("WHERE symbol ILIKE @0", state.Concat(wcep.UF));
                        if (s != null)
                        {
                            ((address)bdgAddress.Current).state_id = s.id;
                            cbStateAddress.EditValue = s.id;
                        }

                        Console.WriteLine(wcep.CIDADE);
                        city c = city.SingleOrDefault("WHERE remove_character(name) ILIKE remove_character(@0)", city.Concat(wcep.CIDADE));
                        if (c != null)
                        {
                            ((address)bdgAddress.Current).city_id = c.id;
                            cbCity.EditValue = c.id;
                        }

                        if (wcep.RESULTADO == 1)
                        {
                            ((address)bdgAddress.Current).district = wcep.BAIRRO;
                            tfDistrict.EditValue = wcep.BAIRRO;

                            string street = String.Format("{0} {1}", wcep.TIPOLAGRADOURO, wcep.LAGRADOURO);
                            ((address)bdgAddress.Current).name = street;
                            tfAddress.EditValue = street;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void tfCep_KeyDown(object sender, KeyEventArgs e)
        {
            btnSearchCEP_Click(sender, e);
        }
    }
}