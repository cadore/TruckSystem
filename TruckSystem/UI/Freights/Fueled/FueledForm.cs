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
using TruckSystem.UI.SplashScreens;

namespace TruckSystem.UI.Freights.Fueled
{
    public partial class FueledForm : DevExpress.XtraEditors.XtraForm
    {
        public fueled NewFueled;
        public FueledForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            bdgFueled.DataSource = new fueled() { freight_id = 0 };
            bdgCustomers.DataSource = customer.Fetch("");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            NewFueled = (fueled)bdgFueled.Current;
            NewFueled.gas_station_name = customer.SingleOrDefault(NewFueled.gas_station_id).corporate_name;
            this.DialogResult = DialogResult.OK;
        }

        private void calcValues(object sender, EventArgs e)
        {
            decimal liters = toDecimal(tfLiters.EditValue);
            decimal value_liters = toDecimal(tfValueLiters.EditValue);
            decimal discount = toDecimal(tfDiscount.EditValue);
            decimal total = ((liters * value_liters) - discount);
            tfTotal.EditValue = total;
            ((fueled)bdgFueled.Current).total = total;
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