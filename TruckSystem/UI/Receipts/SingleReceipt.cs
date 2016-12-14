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
using Receipt;

namespace TruckSystem.UI.Receipts
{
    public partial class SingleReceipt : TruckSystem.UI.Utils.UserControlUtil
    {
        public SingleReceipt()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            bdgState.DataSource = state.Fetch("ORDER BY symbol");
        }

        private void cbState_EditValueChanged(object sender, EventArgs e)
        {
            bdgCity.DataSource = city.Fetch("WHERE state_id=@0", Convert.ToInt32(cbState.EditValue));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgType.EditValue.ToString().Equals("cnpj"))
            {
                tfDocument.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                tfDocument.Properties.Mask.EditMask = "00.000.000/0000-00";
            }
            else
            {
                tfDocument.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                tfDocument.Properties.Mask.EditMask = "000.000.000-00";
            }
            tfDocument.EditValue = "";
            tfDocument.Enabled = true;
            tfDocument.Focus();
            tfDocument.SelectAll();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;

            ReceiptUtil ru = new ReceiptUtil()
            {
                city = String.Format("{0} - {1}", cbCity.Text, cbState.Text),
                cpf_cnpj = tfDocument.EditValue.ToString(),
                date = tfDate.DateTime,
                emitter = tfEmitter.EditValue.ToString(),
                number = Convert.ToInt64(tfNumber.EditValue),
                receive_to = tfReceiveTo.EditValue.ToString(),
                reference = tfReference.EditValue.ToString(),
                value = Convert.ToDecimal(tfValue.EditValue),
                double_print = ckDouble.Checked
            };
            ru.Print();
        }
    }
}
