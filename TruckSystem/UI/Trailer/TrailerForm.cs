using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckSystem.UI.SplashScreens;
using TruckSystem.Utils;

namespace TruckSystem.UI.Trailer
{
    public partial class TrailerForm : TruckSystem.UI.Utils.UserControlUtil
    {
        truck CurrentTruck = null;
        public TrailerForm(truck idTruck)
        {
            InitializeComponent();
            lbDriver.Text = "";
            ControlsUtil.SetBackColor(this.Controls);
            CurrentTruck = idTruck;
            setValidations();
            loadTrucks();            
        }

        private void loadTrucks()
        {
            bdgTruck.DataSource = truck.Fetch("");
        }

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

        #region return trailers
        trailer getTrailer1(long idTruckruck_id)
        {
            if (bdgTrailer1.Current == null)
                return null;
            trailer t1 = (trailer)bdgTrailer1.Current;
            t1.truck_id = idTruckruck_id;
            t1.index = 1;
            if (IsNew)
            {
                t1.registred_by = Singleton.getUser().id;
                t1.registred_at = trailer.Now();
            }
            return t1;
        }
        trailer getTrailer2(long idTruckruck_id)
        {
            if (bdgTrailer2.Current == null)
                return null;
            trailer t2 = (trailer)bdgTrailer2.Current;
            t2.truck_id = idTruckruck_id;
            t2.index = 2;
            if (IsNew)
            {
                t2.registred_by = Singleton.getUser().id;
                t2.registred_at = trailer.Now();
            }
            return t2;
        }
        trailer getTrailer3(long idTruckruck_id)
        {
            if (bdgTrailer3.Current == null)
                return null;
            trailer t3 = (trailer)bdgTrailer3.Current;
            t3.truck_id = idTruckruck_id;
            t3.index = 3;
            if (IsNew)
            {
                t3.registred_by = Singleton.getUser().id;
                t3.registred_at = trailer.Now();
            }
            return t3;
        }
        #endregion

        #region validations
        DXValidationProvider vTrailer1;
        DXValidationProvider vTrailer2;
        DXValidationProvider vTrailer3;
        private void setValidations()
        {
            vTrailer1 = new DXValidationProvider(this.components);
            vTrailer2 = new DXValidationProvider(this.components);
            vTrailer3 = new DXValidationProvider(this.components);
            
            ConditionValidationRule cvBoard = new ConditionValidationRule() { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe a Placa" };
            ConditionValidationRule cvRenavam = new ConditionValidationRule() { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe o Renavam" };
            ConditionValidationRule cvChassi = new ConditionValidationRule() { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe o Chassi" };
            ConditionValidationRule cvAntt = new ConditionValidationRule() { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe a Antt" };
            ConditionValidationRule cvMark = new ConditionValidationRule() { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe a Marca" };
            ConditionValidationRule cvModel = new ConditionValidationRule() { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe o Modelo" };
            ConditionValidationRule cvYearFabrication = new ConditionValidationRule() { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe o Ano de Fabricação" };
            ConditionValidationRule cvYearModel = new ConditionValidationRule() { ConditionOperator = ConditionOperator.IsNotBlank, ErrorText = "Informe o Ano Modelo" };

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool error = false;
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

                /*if (IsNew)
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
                }*/
                using (var scope = trailer.repo.GetTransaction())
                {
                    Console.WriteLine(0);
                    trailer t1 = getTrailer1(CurrentTruck.id);
                    if (t1 != null)
                    {
                        Console.WriteLine(1);
                        t1.Save();
                        tfIdTrailer1.EditValue = t1.id;
                    }
                    trailer t2 = getTrailer2(CurrentTruck.id);
                    if (t2 != null)
                    {
                        Console.WriteLine(2);
                        t2.Save();
                        tfIdTrailer2.EditValue = t2.id;
                    }
                    trailer t3 = getTrailer3(CurrentTruck.id);
                    if (t3 != null)
                    {
                        Console.WriteLine(3);
                        t3.Save();
                        tfIdTrailer3.EditValue = t3.id;
                    }
                    Console.WriteLine(4);
                    scope.Complete();
                    if (this.MessageToSave("Reboque(s)"))
                        desk.AddTabAndCloseCurrent(new TrailerForm(null), "Reboque(s)", false);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void cbTruck_EditValueChanged(object sender, EventArgs e)
        {
            if (cbTruck.EditValue != null || Convert.ToInt64(cbTruck.EditValue) > 0)
            {
                pnTabs.Enabled = true;
                IsNew = true;
                CurrentTruck = truck.SingleOrDefault(Convert.ToInt64(cbTruck.EditValue));
                lbDriver.Text = driver.SingleOrDefault(CurrentTruck.driver_id).full_name;

                trailer tr1 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", CurrentTruck.id, 1);
                if (tr1 != null)
                {
                    ckTrailer1.Checked = true;
                    bdgTrailer1.DataSource = tr1;
                    IsNew = false;
                }
                trailer tr2 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", CurrentTruck.id, 2);
                if (tr2 != null)
                {
                    ckTrailer2.Checked = true;
                    bdgTrailer2.DataSource = tr2;
                    IsNew = false;
                }

                trailer tr3 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", CurrentTruck.id, 3);
                if (tr3 != null)
                {
                    ckTrailer3.Checked = true;
                    bdgTrailer3.DataSource = tr3;
                    IsNew = false;
                }
            }
            else
            {
                pnTabs.Enabled = false;
                lbDriver.Text = "";
                bdgTrailer1.Clear();
                bdgTrailer2.Clear();
                bdgTrailer3.Clear();
            }
        }
    }
}
