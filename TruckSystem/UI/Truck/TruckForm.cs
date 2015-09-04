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
                trailer tr1 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", t.id, 1);
                if (tr1 != null)
                {
                    ckTrailer1.Checked = true;
                    bdgTrailer1.DataSource = tr1;
                }                    
                trailer tr2 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", t.id, 2);
                if (tr2 != null)
                {
                    ckTrailer2.Checked = true;
                    bdgTrailer2.DataSource = tr2;
                }
                    
                trailer tr3 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", t.id, 3);
                if (tr3 != null)
                {
                    ckTrailer3.Checked = true;
                    bdgTrailer3.DataSource = tr3;
                }                    
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
            bool error = false;
            if (!vTruck.Validate())
                error = true;
            if (ckTrailer1.Checked && !vTrailer1.Validate())
                error = true;
            if (ckTrailer2.Checked && !vTrailer2.Validate())
                error = true;
            if (ckTrailer3.Checked && !vTrailer3.Validate())
                error = true;
            if (error)
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

                    trailer t1 = getTrailer1(tr.id);
                    if (t1 != null)
                    {
                        t1.Save();
                        tfIdTrailer1.EditValue = t1.id;
                    }
                    trailer t2 = getTrailer2(tr.id);
                    if (t2 != null)
                    {
                        t2.Save();
                        tfIdTrailer2.EditValue = t2.id;
                    }
                    trailer t3 = getTrailer3(tr.id);
                    if (t3 != null)
                    {
                        t3.Save();
                        tfIdTrailer3.EditValue = t3.id;
                    }
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

        #region return trailers
        trailer getTrailer1(long _truck_id)
        {
            if (bdgTrailer1.Current == null)
                return null;
            trailer t1 = (trailer)bdgTrailer1.Current;
            t1.truck_id = _truck_id;
            t1.index = 1;
            if (IsNew)
            {
                t1.registred_by = Singleton.getUser().id;
                t1.registred_at = trailer.Now();
            }
            return t1;
        }
        trailer getTrailer2(long _truck_id)
        {
            if (bdgTrailer2.Current == null)
                return null;
            trailer t2 = (trailer)bdgTrailer2.Current;
            t2.truck_id = _truck_id;
            t2.index = 2;
            if (IsNew)
            {
                t2.registred_by = Singleton.getUser().id;
                t2.registred_at = trailer.Now();
            }
            return t2;
        }
        trailer getTrailer3(long _truck_id)
        {
            if (bdgTrailer3.Current == null)
                return null;
            trailer t3 = (trailer)bdgTrailer3.Current;
            t3.truck_id = _truck_id;
            t3.index = 3;
            if (IsNew)
            {
                t3.registred_by = Singleton.getUser().id;
                t3.registred_at = trailer.Now();
            }
            return t3;
        }
        #endregion

        private void ckTrailer1_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ck = (CheckEdit)sender;
            ActiveInactivePanel(pnTrailer1, ck);
            tfBoardTrailer1.Focus();
            if (ck.Checked)
                bdgTrailer1.DataSource = new trailer() { index = 1 };
            else
            {
                trailer t1 = ((trailer)bdgTrailer1.Current);
                if ((t1 != null ? t1.id : 0) > 0)
                    trailer.Delete(t1.id);
                bdgTrailer1.Clear();
            }              
        }     

        private void ckTrailer2_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ck = (CheckEdit)sender;
            ActiveInactivePanel(pnTrailer2, ck);
            tfBoardTrailer2.Focus();
            if (ck.Checked)
                bdgTrailer2.DataSource = new trailer() { index = 2 };
            else
            {
                trailer t2 = ((trailer)bdgTrailer2.Current);
                if ((t2 != null ? t2.id : 0) > 0)
                    trailer.Delete(t2.id);
                bdgTrailer2.Clear();
            }
        }

        private void ckTrailer3_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ck = (CheckEdit)sender;
            ActiveInactivePanel(pnTrailer3, ck);
            tfBoardTrailer3.Focus();
            if (ck.Checked)
                bdgTrailer3.DataSource = new trailer() { index = 3 };
            else
            {
                trailer t3 = ((trailer)bdgTrailer3.Current);
                if ((t3 != null ? t3.id : 0) > 0)
                    trailer.Delete(t3.id);
                bdgTrailer3.Clear();
            }
        }
        private void ActiveInactivePanel(PanelControl panel, CheckEdit ck)
        {
            foreach (Control c in panel.Controls)
            {
                if (c.GetType().ToString().Equals("DevExpress.XtraEditors.TextEdit"))
                {
                    ((DevExpress.XtraEditors.TextEdit)c).Enabled = ck.Checked;
                }
                if (c.GetType().ToString().Equals("DevExpress.XtraEditors.LabelControl"))
                {
                    ((DevExpress.XtraEditors.LabelControl)c).Enabled = ck.Checked;
                }
                vTrailer1.RemoveControlError(c);
                vTrailer2.RemoveControlError(c);
                vTrailer3.RemoveControlError(c);
            }
        }

        #region validations
        DXValidationProvider vTruck;
        DXValidationProvider vTrailer1;
        DXValidationProvider vTrailer2;
        DXValidationProvider vTrailer3;
        private void setValidations()
        {
            vTruck = new DXValidationProvider(this.components);
            vTrailer1 = new DXValidationProvider(this.components);
            vTrailer2 = new DXValidationProvider(this.components);
            vTrailer3 = new DXValidationProvider(this.components);

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

            this.vTrailer1.SetValidationRule(tfBoardTrailer1, cvBoard);
            this.vTrailer1.SetValidationRule(tfRenavamTrailer1, cvRenavam);
            this.vTrailer1.SetValidationRule(tfChassiTrailer1, cvChassi);
            this.vTrailer1.SetValidationRule(tfAnttTrailer1, cvAntt);
            this.vTrailer1.SetValidationRule(tfMarkTrailer1, cvMark);
            this.vTrailer1.SetValidationRule(tfModelTrailer1, cvModel);
            this.vTrailer1.SetValidationRule(tfYearFabricationTrailer1, cvYearFabrication);
            this.vTrailer1.SetValidationRule(tfYearModelTrailer1, cvYearModel);

            this.vTrailer2.SetValidationRule(tfBoardTrailer2, cvBoard);
            this.vTrailer2.SetValidationRule(tfRenavamTrailer2, cvRenavam);
            this.vTrailer2.SetValidationRule(tfChassiTrailer2, cvChassi);
            this.vTrailer2.SetValidationRule(tfAnttTrailer2, cvAntt);
            this.vTrailer2.SetValidationRule(tfMarkTrailer2, cvMark);
            this.vTrailer2.SetValidationRule(tfModelTrailer2, cvModel);
            this.vTrailer2.SetValidationRule(tfYearFabricationTrailer2, cvYearFabrication);
            this.vTrailer2.SetValidationRule(tfYearModelTrailer2, cvYearModel);
                        
            this.vTrailer3.SetValidationRule(tfBoardTrailer3, cvBoard);
            this.vTrailer3.SetValidationRule(tfRenavamTrailer3, cvRenavam);
            this.vTrailer3.SetValidationRule(tfChassiTrailer3, cvChassi);
            this.vTrailer3.SetValidationRule(tfAnttTrailer3, cvAntt);
            this.vTrailer3.SetValidationRule(tfMarkTrailer3, cvMark);
            this.vTrailer3.SetValidationRule(tfModelTrailer3, cvModel);
            this.vTrailer3.SetValidationRule(tfYearFabricationTrailer3, cvYearFabrication);
            this.vTrailer3.SetValidationRule(tfYearModelTrailer3, cvYearModel);
        }
        #endregion

        private void ckTrailer_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            CheckEdit ck = (CheckEdit)sender;
            if (ck.Checked)
            {
                DialogResult rs = XtraMessageBox.Show("Confirma a exclusão deste reboque?\nNão será possível reverter esta ação!",
                    "Cadore Tecnologia", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }            
        }
    }
}
