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

namespace TruckSystem.UI.Deposits
{
    public partial class ViewDepositsForm : DevExpress.XtraEditors.XtraForm
    {
        public ViewDepositsForm(List<deposits> ld)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);

            if (ld == null)
            {
                ld = new List<deposits>();
                ld.Clear();
            }
            else
            {
                for (int i = 0; i < ld.Count; i++)
                {
                    /*bank_account ba = bank_account.SingleOrDefault(ld[i].account_id);
                    ld[i].account = String.Format("{0} - {1}", ba.agency, ba.account);
                    ld[i].customer_name = customer.SingleOrDefault(ld[i].customer_id).corporate_name;
                    ld[i].type_name = ld[i].type == 0 ? "Dinheiro" : "Cheque";
                    ld[i].truck_board = truck.SingleOrDefault(ld[i].truck_id).board;*/
                }
            }
            bdgDeposits.DataSource = ld;
        }
    }
}