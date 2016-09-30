using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraSplashScreen;
using TruckSystem.UI.SplashScreens;
using TruckSystem.Utils;
using TruckSystem.FileManager.UI;
using PetaPoco;

namespace TruckSystem.UI.Truck
{
    public partial class TruckForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public TruckForm(truck t)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            setValidations();
            loadData(null, null);
            if (t == null)
            {
                t = new truck();                
                IsNew = true;
            }
            else
            {
                tfBoardTruck.Properties.ReadOnly = true;              
            }
            bdgTruck.DataSource = t;            
        }

        private void loadData(object sender, EventArgs e)
        {
            bdgDriver.DataSource = driver.Fetch("WHERE inactive=FALSE");

            List<antts> listAntt = antts.Fetch("WHERE status_rntrc='ATIVO' AND validation_date >= @0", antts.Now());
            for (int i = 0; i < listAntt.Count; i++)
            {
                customer c = customer.SingleOrDefault(listAntt[i].customer_id);
                listAntt[i].customer_name = c.corporate_name;
                listAntt[i].customer_cnpj = c.document;
            }
            bdgAntt.DataSource = listAntt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (!vTruck.Validate())
                return;
            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);

                if (IsNew)
                {
                    if (!Validations.Unique.BoardTruckIsUnique((truck)bdgTruck.Current))
                    {
                        SplashScreenManager.CloseForm(false);
                        XtraMessageBox.Show("Placa já cadastrada, verifique!");
                        return;
                    }
                    if (!Validations.Unique.DriverTruckIsUnique((truck)bdgTruck.Current))
                    {
                        SplashScreenManager.CloseForm(false);
                        XtraMessageBox.Show("Motorista ja cadastrado para outro caminhão, verifique!");
                        return;
                    }
                }
                using (var scope = truck.repo.GetTransaction())
                {
                    truck tr = (truck)bdgTruck.Current;
                    if (IsNew)
                    {
                        tr.registred_by = Singleton.getUser().id;
                        tr.registred_at = trailer.Now();
                    }
                    tr.Save();
                    tfIdTruck.EditValue = tr.id;
                    scope.Complete();
                    XtraMessageBox.Show(String.Format("Veículo {0} salvo com sucesso.", tr.board));
                    desk.AddTabAndCloseCurrent(new TruckForm(truck.SingleOrDefault(tr.id)), "Editar caminhão", false);
                    //if (this.MessageToSave("Caminhão"))
                      //  desk.AddTabAndCloseCurrent(new TruckForm(null), "Novo caminhão", false);

                }
            }
            catch (Exception ex)
            {
                truck.repo.AbortTransaction();
                XtraMessageBox.Show(String.Format("Ocorre um erro:\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }
        #region validations
        DXValidationProvider vTruck;
        private void setValidations()
        {
            vTruck = new DXValidationProvider(this.components);

            ConditionValidatonRule cvDriver = new ConditionValidatonRule() 
            { ConditionOperator = ConditionOperator.Greater, Value1 = (long)0, ErrorText = "Informe o Motorista" };
            ConditionValidationRule cvBoard = new ConditionValidationRule()
            { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe a Placa" };
            ConditionValidationRule cvRenavam = new ConditionValidationRule() 
            { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe o Renavam" };
            ConditionValidationRule cvChassi = new ConditionValidationRule() 
            { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe o Chassi" };
            ConditionValidationRule cvAntt = new ConditionValidationRule() 
            { ConditionOperator = ConditionOperator.Greater, ErrorText = "Informe a Antt", Value1 = (long)0 };
            ConditionValidationRule cvMark = new ConditionValidationRule() 
            { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe a Marca" };
            ConditionValidationRule cvModel = new ConditionValidationRule() 
            { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe o Modelo" };
            ConditionValidationRule cvYearFabrication = new ConditionValidationRule() 
            { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe o Ano de Fabricação" };
            ConditionValidationRule cvYearModel = new ConditionValidationRule() 
            { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe o Ano Modelo" };

            this.vTruck.SetValidationRule(cbDriver, cvDriver);
            this.vTruck.SetValidationRule(tfBoardTruck, cvBoard);
            this.vTruck.SetValidationRule(tfRenavamTruck, cvRenavam);
            this.vTruck.SetValidationRule(tfChassiTruck, cvChassi);
            this.vTruck.SetValidationRule(tfMarkTruck, cvMark);
            this.vTruck.SetValidationRule(tfModelTruck, cvModel);
            this.vTruck.SetValidationRule(tfYearFabricationTruck, cvYearFabrication);
            this.vTruck.SetValidationRule(tfYearModelTruck, cvYearModel);
            this.vTruck.SetValidationRule(cbAntt, cvAntt);
        }
        #endregion        

        private void btnNew_Click(object sender, EventArgs e)
        {
            desk.AddTabAndCloseCurrent(new TruckForm(null), "Novo caminhão", false);
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            FileManagerForm fmf = new FileManagerForm(Enums.TypePath.trucks, ((truck)bdgTruck.Current).id);
            fmf.ShowDialog();
        }
    }
}
