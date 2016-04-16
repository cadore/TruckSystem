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

namespace TruckSystem.UI.Truck
{
    public partial class TruckForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public TruckForm(truck t)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            setValidations();
            loadDrivers(null, null);
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

        private void loadDrivers(object sender, EventArgs e)
        {
            bdgDriver.DataSource = driver.Fetch("WHERE inactive=FALSE");
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
                    if (this.MessageToSave("Caminhão"))
                        desk.AddTabAndCloseCurrent(new TruckForm(null), "Novo caminhão", false);

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
            { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe a Antt" };
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
            this.vTruck.SetValidationRule(tfAnttTruck, cvAntt);
            this.vTruck.SetValidationRule(tfMarkTruck, cvMark);
            this.vTruck.SetValidationRule(tfModelTruck, cvModel);
            this.vTruck.SetValidationRule(tfYearFabricationTruck, cvYearFabrication);
            this.vTruck.SetValidationRule(tfYearModelTruck, cvYearModel);
        }
        #endregion        
    }
}
