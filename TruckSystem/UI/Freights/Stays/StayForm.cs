using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckSystem.UI.Utils;
using DevExpress.XtraEditors;

namespace TruckSystem.UI.Freights.Stays
{
    public partial class StayForm : DevExpress.XtraEditors.XtraForm
    {
        freight f;
        public StayForm(freight _f)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            f = _f;
            stay s = stay.SingleOrDefault("WHERE freight_id=@0", f.id);
            if (s == null)
                s = new stay();
            bdgStay.DataSource = s;

            tfTruck.EditValue = truck.SingleOrDefault(f.truck_id).board;
            tfNameDriver.EditValue = driver.SingleOrDefault(f.driver_id).full_name;
            tfFreight.EditValue = f.id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            try
            {
                stay s = (stay)bdgStay.Current;
                s.freight_id = f.id;
                s.driver_id = f.driver_id;
                s.truck_id = f.truck_id;
                s.registred_at = stay.Now();
                s.registred_by = Singleton.getUser().id;
                s.Save();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;
                XtraMessageBox.Show(string.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }            
            this.Close();
        }

        decimal getTotalHors()
        {
            DateTime start = new DateTime(tfDateStart.DateTime.Year, tfDateStart.DateTime.Month, tfDateStart.DateTime.Day, 
                tfTimeStart.Time.Hour, tfTimeStart.Time.Minute, 0);
            DateTime end = new DateTime(tfDateEnd.DateTime.Year, tfDateEnd.DateTime.Month, tfDateEnd.DateTime.Day,
                tfTimeEnd.Time.Hour, tfTimeEnd.Time.Minute, 0);            
            TimeSpan ts = end - start;
            return Convert.ToDecimal(ts.TotalHours);
        }

        void calcValues(object sender, EventArgs e)
        {
            decimal totalHors = toDecimal(getTotalHors());
            decimal weight = toDecimal(f.weight);
            decimal valueHor = toDecimal(tfValueHor.EditValue);
            decimal valueStay = (weight * valueHor) * totalHors;
            tfValueEstay.EditValue = valueStay;
            decimal taxe_comission = toDecimal(tfTaxeComission.EditValue);
            decimal comission = (valueStay * taxe_comission) / 100;
            tfTotalComission.EditValue = comission;
            ((stay)bdgStay.Current).total_comission = comission;
            tfTotal.EditValue = valueStay - comission;
            ((stay)bdgStay.Current).total = valueStay - comission;
            
        }
        decimal toDecimal(object v)
        {
            if (v == null || v.Equals(DBNull.Value) || String.IsNullOrEmpty(v.ToString()))
                v = "0";
            decimal output;
            Decimal.TryParse(v.ToString(), out output);
            return output;
        }
    }
}
