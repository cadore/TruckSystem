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
    public partial class ViewOutputsForm : DevExpress.XtraEditors.XtraForm
    {
        freight fre;
        public ViewOutputsForm(List<output> lo, freight fr)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            fre = fr;
            if (lo == null)
            {
                bdgOutputs.DataSource = new List<output>();
                bdgOutputs.Clear();                
            }
            else
            {
                for (int i = 0; i < lo.Count; i++)
                    lo[i].customer_name = customer.SingleOrDefault(lo[i].customer_id).corporate_name;
                bdgOutputs.DataSource = lo;
            }
            if(bdgOutputs.Count == 0)
                btnAdd_Click(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bdgOutputs.Current != null)
            {
                output p = (output)bdgOutputs.Current;
                if (p.id > 0)
                    output.Delete(p.id);
                bdgOutputs.RemoveCurrent();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OutputsFreightForm off = new OutputsFreightForm(fre);
            if (off.ShowDialog() == DialogResult.OK)
            {
                bdgOutputs.Add(off.NewOutput);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}