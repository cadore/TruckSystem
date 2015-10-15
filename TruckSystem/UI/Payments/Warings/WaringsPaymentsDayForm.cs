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
using TruckSystem.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace TruckSystem.UI.Payments.Warings
{
    public partial class WaringsPaymentsDayForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public WaringsPaymentsDayForm()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            ResizeP();
            loadData();
        }

        private void loadData()
        {
            DateTime cdate = payment.Now();
            DateTime cPlusDate = cdate.AddDays(1);
            DateTime dStartNextWeek = Dates.GetDateStartWeek(cdate, 0);
            DateTime dEndNextWeek = Dates.GetDateEndWeek(cdate, 6);

            pDay.Text = String.Format("Pagamentos do Dia ({0:dd/MM/yyyy})", cdate);
            if (cdate.DayOfWeek == DayOfWeek.Saturday || cdate.DayOfWeek == DayOfWeek.Sunday)
                pDay.AppearanceCaption.ForeColor = Color.FromArgb(255, 40, 25);

            pTomorrow.Text = String.Format("Pagamentos para Amanhã ({0:dd/MM/yyyy})", cPlusDate);
            if (cPlusDate.DayOfWeek == DayOfWeek.Saturday || cPlusDate.DayOfWeek == DayOfWeek.Sunday)
                pTomorrow.AppearanceCaption.ForeColor = Color.FromArgb(255, 40, 25);

            pNextWeek.Text = String.Format("Pagamentos para a semana. "
                                            + "{0} semana do mês. ({1:dd/MM/yyyy} à {2:dd/MM/yyyy})",
                                            Dates.GetWeekOfMonthExtensive(cdate), dStartNextWeek, dEndNextWeek);

            string sqlPDay = String.Format("WHERE expiration_date::date = '{0:yyyy-MM-dd}' AND paid=FALSE ORDER BY description",
                cdate);
            string sqlPTomorrow = String.Format("WHERE expiration_date::date = '{0:yyyy-MM-dd}' AND paid=FALSE"
                                                + " ORDER BY description", cPlusDate);
            string sqlNextWeek = String.Format("WHERE expiration_date::date BETWEEN '{0:yyyy-MM-dd}' AND '{1:yyyy-MM-dd}'"
                                                + " AND paid=FALSE ORDER BY expiration_date, description", cdate, dEndNextWeek);

            bdgPDay.DataSource = payment.Fetch(sqlPDay);
            bdgPTomorrow.DataSource = payment.Fetch(sqlPTomorrow);
            bdgNextWeek.DataSource = payment.Fetch(sqlNextWeek);
        }
        public void ResizeP()
        {
            Size tsize = this.Size;
            pDay.Width = (tsize.Width / 3) - 35;
            pTomorrow.Width = (tsize.Width / 3) - 30;
        }

        private void WaringsDayForm_Resize(object sender, EventArgs e)
        {
            ResizeP();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "expiration_date")
            {
                DateTime d = Convert.ToDateTime(e.CellValue);
                if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
                {
                    e.Appearance.BackColor = Color.FromArgb(255, 40, 25);
                    e.Appearance.BackColor2 = Color.WhiteSmoke;
                    e.Appearance.BorderColor = Color.WhiteSmoke;
                }               
            }
        }

        private void GridDoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridControl grid = (GridControl)sender;
                BindingSource bdg = (BindingSource)grid.DataSource;
                payment p = (payment)bdg.Current;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu o erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }
        
    }
}
