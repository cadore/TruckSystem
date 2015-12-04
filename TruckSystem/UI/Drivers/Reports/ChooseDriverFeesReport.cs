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
using DevExpress.XtraReports.UI;
using TruckSystem.UI.Reports.Drivers;
using TruckSystem.Models.Reports;
using DevExpress.XtraSplashScreen;
using TruckSystem.UI.SplashScreens;

namespace TruckSystem.UI.Drivers.Reports
{
    public partial class ChooseDriverFeesReport : DevExpress.XtraEditors.XtraForm
    {
        public ChooseDriverFeesReport()
        {
            InitializeComponent();
            bdgDrivers.DataSource = driver.Fetch("");
            DateTime dt = driver.Now();
            cbMonth.EditValue = dt.Month;
            cbYear.EditValue = dt.Year;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            try
            {
                SplashScreenManager.ShowForm(this, typeof(PleaseWaitForm), false, false, false);
                DateTime first = new DateTime(Convert.ToInt32(cbYear.EditValue), Convert.ToInt32(cbMonth.EditValue), 1);
                DateTime last = new DateTime(Convert.ToInt32(cbYear.EditValue), Convert.ToInt32(cbMonth.EditValue),
                    DateTime.DaysInMonth(Convert.ToInt32(cbYear.EditValue), Convert.ToInt32(cbMonth.EditValue)));

                driver d = driver.SingleOrDefault(Convert.ToInt64(cbDriver.EditValue));
                List<FeesDriverList> fdl = new List<FeesDriverList>();
                string sql = String.Format("WHERE driver_id = {0} AND start::date BETWEEN '{1:yyyy-MM-dd}' AND '{2:yyyy-MM-dd}' ORDER BY start",
                    d.id, first, last);
                List<freight> fre = freight.Fetch(sql);
                if (fre.Count <= 0)
                {
                    SplashScreenManager.CloseForm(false);
                    XtraMessageBox.Show("Não foi encontrado resultados para este período!");
                    return;
                }
                foreach (freight fr in fre)
                {
                    fdl.Add(new FeesDriverList()
                    {
                        date = Convert.ToDateTime(fr.start),
                        driver = d.full_name,
                        freight_id = fr.id.ToString(),
                        value = fr.value_comission
                    });
                }

                FeesDriverModel f = new FeesDriverModel();
                f.feesList = fdl;
                f.document_driver = d.cpf;
                f.driver = d.full_name;
                f.emission_at = String.Format("Emitido em {0:dd/MM/yyyy HH:mm}", driver.Now());
                f.reference = String.Format("Referente à {0} de {1}", cbMonth.Text, cbYear.EditValue);
                f.signature = "Emitido por CadoreTecnologia";


                FeesDriverReport report = new FeesDriverReport();
                report.bdgFees.DataSource = f;

                foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                {
                    p.Visible = false;
                }
                /*PdfExportOptions po = new PdfExportOptions() {ImageQuality = PdfJpegImageQuality.Highest, Compressed = true };
                report.ExportToPdf("C:\\Users\\William\\Desktop\\testePDF.pdf", po);*/

                /*HtmlExportOptions htmlOptions = report.ExportOptions.Html;
                htmlOptions.CharacterSet = "UTF-8";
                htmlOptions.TableLayout = false;
                htmlOptions.RemoveSecondarySymbols = false;
                htmlOptions.Title = "Teste relatório HTML";
                htmlOptions.ExportMode = HtmlExportMode.SingleFilePageByPage;
                htmlOptions.PageBorderColor = Color.Blue;
                htmlOptions.PageBorderWidth = 3;            
                report.ExportToHtml("C:\\Users\\William\\Desktop\\testeHTML.html");*/
                ReportPrintTool tool = new ReportPrintTool(report);
                SplashScreenManager.CloseForm(false);
                tool.ShowRibbonPreviewDialog();
                //this.Close();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }
    }
}