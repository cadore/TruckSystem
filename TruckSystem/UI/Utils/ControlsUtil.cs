using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckSystem.Utils;

namespace TruckSystem.UI
{
    public class ControlsUtil
    {
        static string strPanel = "DevExpress.XtraEditors.PanelControl";
        static string strGroup = "DevExpress.XtraEditors.GroupControl";
        public static void SetBackColor(Control.ControlCollection listC)
        {
            foreach (Control c in listC)
            {
                if (c.GetType().ToString().Equals(strPanel) || c.GetType().ToString().Equals(strGroup))
                {
                    SetBackColor(c.Controls);
                }
                else
                    setAppearanceFocused(c);
            }
        }


        static void setAppearanceFocused(Control item)
        {
            string c = INI.ReadValue("SYSTEM", "AppearanceFocused");
            string[] color;
            if (String.IsNullOrEmpty(c))
                color = new string[] { "216", "216", "216" };
            else
                color = c.Split(';');

            int red = Convert.ToInt32(color[0]);
            int green = Convert.ToInt32(color[1]);
            int blue = Convert.ToInt32(color[2]);
            Color col = Color.FromArgb(red, green, blue);
            switch (item.GetType().ToString())
            {                
                case "DevExpress.XtraEditors.RadioGroup" : ((RadioGroup)item).Properties.AppearanceFocused.BackColor = col; break;
                case "DevExpress.XtraEditors.CheckEdit" : ((CheckEdit)item).Properties.AppearanceFocused.BackColor = col; break;
                case "DevExpress.XtraEditors.CalcEdit" : ((CalcEdit)item).Properties.AppearanceFocused.BackColor = col; break;
                case "DevExpress.XtraEditors.DateEdit" : ((DateEdit)item).Properties.AppearanceFocused.BackColor = col; break;                
                case "DevExpress.XtraEditors.ComboBoxEdit": ((ComboBoxEdit)item).Properties.AppearanceFocused.BackColor = col; break;
                case "DevExpress.XtraEditors.SearchLookUpEdit": ((SearchLookUpEdit)item).Properties.AppearanceFocused.BackColor = col; break;
                case "DevExpress.XtraEditors.TextEdit": ((TextEdit)item).Properties.AppearanceFocused.BackColor = col; break;
                case "DevExpress.XtraEditors.MemoEdit": ((MemoEdit)item).Properties.AppearanceFocused.BackColor = col; break;
            }
        }
    }
}