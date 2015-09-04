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
using TruckSystem.Utils;

namespace TruckSystem.UI
{
    public partial class ChooseColorFocusedForm : DevExpress.XtraEditors.XtraForm
    {
        public ChooseColorFocusedForm()
        {
            InitializeComponent();
            string c = INI.ReadValue("SYSTEM", "AppearanceFocused");
            string[] color;
            if (String.IsNullOrEmpty(c))
                color = new string[] { "235", "235", "235" };
            else
                color = c.Split(';');

            int red = Convert.ToInt32(color[0]);
            int green = Convert.ToInt32(color[1]);
            int blue = Convert.ToInt32(color[2]);
            Color col = Color.FromArgb(red, green, blue);
            colorEdit.Color = col;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            Color c = colorEdit.Color;
            string color = String.Format("{0};{1};{2}", c.R, c.G, c.B);
            INI.WriteValue("SYSTEM", "AppearanceFocused", color);

            XtraMessageBox.Show("Atualizado com sucesso!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}