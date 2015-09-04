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

namespace TruckSystem.UI.Freights.Fueled
{
    public partial class ViewFueledsForm : DevExpress.XtraEditors.XtraForm
    {
        public ViewFueledsForm(List<fueled> lf)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            if (lf == null)
            {
                bdgFueleds.DataSource = new List<fueled>();
                bdgFueleds.Clear();
                btnAdd_Click(this, null);
            }
            else
            {
                for (int i = 0; i < lf.Count; i++)
                    lf[i].gas_station_name = customer.SingleOrDefault(lf[i].gas_station_id).corporate_name;
                    bdgFueleds.DataSource = lf;
            }
            if (bdgFueleds.Count == 0)
                btnAdd_Click(this, null);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (bdgFueleds.Current == null)
                return;
            fueled f = ((fueled)bdgFueleds.Current);
            if (f.id > 0)
                fueled.Delete(f.id);
            bdgFueleds.RemoveCurrent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FueledForm ff = new FueledForm();
            if (ff.ShowDialog() == DialogResult.OK)
            {
                bdgFueleds.Add(ff.NewFueled);
            }
        }
    }
}