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

namespace TruckSystem.UI.Lubrifications
{
    public partial class ViewLubrificationsForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public ViewLubrificationsForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
        }
    }
}
