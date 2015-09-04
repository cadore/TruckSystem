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

namespace TruckSystem.UI.Utils
{
    public partial class InputMessageForm : DevExpress.XtraEditors.XtraForm
    {
        public object Value { get; set; }

        public InputMessageForm(string caption, FormatValue fv)
        {
            InitializeComponent();
            this.pnPrincipal.Text = caption;

            if (fv == FormatValue.Decimal)
            {
                tfValue.Properties.Mask.EditMask = "c2";
                tfValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            }
            else if (fv == FormatValue.Integer)
            {
                tfValue.Properties.Mask.EditMask = "n2";
                tfValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            }
            else if (fv == FormatValue.String)
            {
                tfValue.Properties.Mask.EditMask = "";
                tfValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            }
            tfValue.Properties.Mask.UseMaskAsDisplayFormat = true;
            if (Value != null)
            {
                tfValue.EditValue = Value;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Value = tfValue.EditValue;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public enum FormatValue
        {
            String = 0,
            Decimal = 1,
            Integer = 2,
            Long = 3
        }

        private void tfValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);
        }
    }
}