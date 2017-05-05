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
        freight fre;
        public ViewDepositsForm(List<deposits> _ld, freight _fre)
        {
            List<deposits> ld = _ld;// new List<deposits>();
            //ld.Clear();
            //foreach (deposits d in _ld)
               // ld.Add(d);

            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            fre = _fre;

            if (ld == null)
            {
                ld = new List<deposits>();
                ld.Clear();
            }
            else
            {
                for (int i = 0; i < ld.Count; i++)
                {
                    bank_account ba = bank_account.SingleOrDefault(ld[i].account_id);
                    banks b = banks.SingleOrDefault(ba.bank_id);
                    ld[i].account = String.Format("{0}/{1} - {2}/{3}", ba.agency, ba.account, b.code, b.name);
                    ld[i].customer_name = customer.SingleOrDefault(ld[i].customer_id).corporate_name;
                    ld[i].type_name = ld[i].type == 0 ? "Dinheiro" : "Cheque";
                    ld[i].truck_board = truck.SingleOrDefault(ld[i].truck_id).board;
                }
            }
            bdgDeposits.DataSource = ld;
            if (bdgDeposits.Count == 0)
                btnAdd_Click(this, null);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deposits d = (deposits)bdgDeposits.Current;
            if (bdgDeposits.Current != null && d.id > 0)
            {
                deposits.Delete(d.id);
                bdgDeposits.RemoveCurrent();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewDepositForm ndf = new NewDepositForm(null, fre);
            if(ndf.ShowDialog() == DialogResult.OK)
            {
                deposits dp = ndf.NewDeposit;
                bank_account ba = bank_account.SingleOrDefault(dp.account_id);
                dp.account = String.Format("{0} - {1}", ba.agency, ba.account);
                dp.customer_name = customer.SingleOrDefault(dp.customer_id).corporate_name;
                dp.type_name = dp.type == 0 ? "Dinheiro" : "Cheque";
                dp.truck_board = truck.SingleOrDefault(dp.truck_id).board;
                bdgDeposits.Add(dp);
            }
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            deposits d = (deposits)bdgDeposits.Current;
            NewDepositForm ndf = new NewDepositForm(d, fre);
            if (ndf.ShowDialog() == DialogResult.OK)
            {
                deposits dp = ndf.NewDeposit;
                bank_account ba = bank_account.SingleOrDefault(dp.account_id);
                dp.account = String.Format("{0} - {1}", ba.agency, ba.account);
                dp.customer_name = customer.SingleOrDefault(dp.customer_id).corporate_name;
                dp.type_name = dp.type == 0 ? "Dinheiro" : "Cheque";
                dp.truck_board = truck.SingleOrDefault(dp.truck_id).board;
                bdgDeposits.Remove(d);
                bdgDeposits.Add(dp);
            }
        }
    }
}