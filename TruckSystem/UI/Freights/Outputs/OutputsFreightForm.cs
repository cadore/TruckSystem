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

namespace TruckSystem.UI.Freights.Outputs
{
    public partial class OutputsFreightForm : DevExpress.XtraEditors.XtraForm
    {
        public output NewOutput;
        public OutputsFreightForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            bdgOutput.DataSource = new output();
            bdgCustomers.DataSource = customer.Fetch("");
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
            NewOutput = (output)bdgOutput.Current;
            NewOutput.customer_name = customer.SingleOrDefault(NewOutput.customer_id).corporate_name;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}