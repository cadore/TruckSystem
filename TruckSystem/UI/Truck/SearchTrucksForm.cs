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

namespace TruckSystem.UI.Truck
{
    public partial class SearchTrucksForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public SearchTrucksForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            rgType.EditValue = "all";
        }

        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string st = rgType.EditValue.ToString();
            if (st.Equals("board"))
            {
                tfType.EditValue = null;
                cbDriver.EditValue = 0;
                tfType.Properties.Mask.EditMask = "[A-Z]{3}-[0-9]{4}";
                tfType.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                tfType.Enabled = true;
                lbType.Enabled = true;
                cbDriver.Enabled = false;
                lbDriver.Enabled = false;
                lbType.Text = "Placa:";
                tfType.Focus();
                tfType.SelectAll();
            }
            else if (st.Equals("antt"))
            {
                tfType.EditValue = null;
                cbDriver.EditValue = 0;
                tfType.Properties.Mask.EditMask = @"d";
                tfType.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                tfType.Enabled = true;
                lbType.Enabled = true;
                cbDriver.Enabled = false;
                lbDriver.Enabled = false;
                lbType.Text = "ANTT:";
                tfType.Focus();
                tfType.SelectAll();
            }
            else if(st.Equals("driver"))
            {
                tfType.EditValue = null;
                cbDriver.EditValue = 0;
                bdgDrivers.DataSource = driver.Fetch("WHERE inactive=FALSE");
                tfType.Enabled = false;
                lbType.Enabled = false;
                cbDriver.Enabled = true;
                lbDriver.Enabled = true;
                cbDriver.Focus();
            }
            else
            {
                tfType.EditValue = null;
                cbDriver.EditValue = 0;
                tfType.Enabled = false;
                lbType.Enabled = false;
                cbDriver.Enabled = false;
                lbDriver.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<truck> listT = null;
            string st = rgType.EditValue.ToString();
            if (st.Equals("board"))
            {
                listT = truck.Fetch("WHERE board=@0 ORDER BY id", tfType.EditValue);
            }
            else if (st.Equals("antt"))
            {
                listT = truck.Fetch("WHERE antt=@0 ORDER BY id", tfType.EditValue);
            }
            else if(st.Equals("driver"))
            {
                listT = truck.Fetch("WHERE driver_id=@0 ORDER BY id", cbDriver.EditValue);
            }
            else
            {
                listT = truck.Fetch("ORDER BY id");
            }
            try
            {
                for (int i = 0; i < listT.Count; i++)
                {
                    listT[i].driver_name = driver.SingleOrDefault(listT[i].driver_id).full_name;
                    listT[i].antt = Convert.ToInt32(antts.SingleOrDefault(listT[i].antt_id).rntrc);
                }
            }
            catch (Exception) { }
            bdgTrucks.DataSource = listT;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }     

        private void tfType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (bdgTrucks.Current != null)
            {
                TruckForm tf = new TruckForm((truck)bdgTrucks.Current);
                desk.AddTab(tf, "Edição de Caminhão", true);
            }            
        }
    }
}
