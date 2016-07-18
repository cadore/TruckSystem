using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using TruckSystem.Utils;
using DevExpress.XtraTab.ViewInfo;
using TruckSystem.UI.Customer;
using TruckSystem.UI.Utils;
using TruckSystem.UI.BankAccounts;
using TruckSystem.UI.Drivers;
using TruckSystem.UI.Truck;
using TruckSystem.UI.Freights;
using TruckSystem.UI.Payments;
using System.IO;
using TruckSystem.Connection;
using TruckSystem.UI.SplashScreens;
using TruckSystem.UI.SearchCNPJ;
using TruckSystem.UI.AccountsToPay;
using TruckSystem.UI.Receipts;
using System.Globalization;
using TruckSystem.UI.Payments.Warings;
using TruckSystem.UI.Drivers.Reports;
using DevExpress.XtraReports.UI;
using TruckSystem.UI.Reports.Freights;
using TruckSystem.Models.Reports;
using TruckSystem.UI.Truck.Reports;
using TruckSystem.UI.Trailer;
using TruckSystem.UI.Business;

namespace TruckSystem.UI
{
    public partial class DesktopForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TabControlUtil tabUtil;
        public DesktopForm()
        {
            InitializeComponent();
            tabUtil = new TabControlUtil(this);
            UserControlUtil.desk = this;

            AddTab(new WaringsPaymentsDayForm(), "Pagamentos", true);

            SplashScreenManager.CloseForm(false);
        }

        public void AddTab(XtraUserControl userControl, string titleTab, bool newTab)
        {
            tabUtil.AddTab(userControl, titleTab, newTab);
        }

        public void AddTabAndCloseCurrent(XtraUserControl userControl, string titleTab, bool newTab)
        {
            tabUtil.CloseSelectedPage();
            tabUtil.AddTab(userControl, titleTab, newTab);
        }

        public void CloseCurrentTab()
        {
            tabUtil.CloseSelectedPage();
        }

        private void tabControl_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (Convert.ToInt32(e.Button.Tag) != 1
                || this.tabControl.TabPages.Count <= 0
                || XtraMessageBox.Show("Tem certeza que deseja fechar todas as guias?", "Confirmação de fechamento",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;
            this.tabControl.TabPages.Clear();
        }

        private void tabControl_CloseButtonClick(object sender, EventArgs e)
        {
            this.tabControl.TabPages.Remove((e as ClosePageButtonEventArgs).Page as XtraTabPage);
        }

        private void DesktopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabControl.TabPages.Count > 1)
            {
                DialogResult rs = XtraMessageBox.Show("Deseja realmente sair?", "Confirmação de Saída",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rs == DialogResult.No)
                    e.Cancel = true;
            }
        }       

        private void tabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            if (tabUtil != null)
                tabUtil.CenterControlsInPanel();
        }

        private void tabControl_Resize(object sender, EventArgs e)
        {
            if (tabUtil != null)
                tabUtil.CenterControlsInPanel();
        }

        private void btnNewCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomerForm cf = new CustomerForm(null);
            AddTab(cf, "Novo Cliente", false);
        }

        private void btnSearchCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchCustomersForm scf = new SearchCustomersForm();
            AddTab(scf, "Buscar Clientes", false);
        }

        private void btnManagerAccountants_ItemClick(object sender, ItemClickEventArgs e)
        {
            ManagerBankAccountsForm mbaf = new ManagerBankAccountsForm();
            mbaf.ShowDialog();
        }

        private void btnSearchDriver_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchDriversForm sdf = new SearchDriversForm();
            AddTab(sdf, "Buscar Motoristas", false);
        }

        private void btnNewDriver_ItemClick(object sender, ItemClickEventArgs e)
        {
            DriverForm df = new DriverForm(null);
            AddTab(df, "Novo Motorista", false);
        }

        private void btnSearchTrucks_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchTrucksForm stf = new SearchTrucksForm();
            AddTab(stf, "Buscar Caminhões", false);
        }

        private void btnNewTruck_ItemClick(object sender, ItemClickEventArgs e)
        {
            TruckForm tf = new TruckForm(null);
            AddTab(tf, "Novo Caminhão", false);
        }

        private void btnNewFreight_ItemClick(object sender, ItemClickEventArgs e)
        {
            FreightForm ff = new FreightForm(null);
            AddTab(ff, "Novo Frete", false);
        }

        private void btnSearchFreights_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchFreightsForm sff = new SearchFreightsForm();
            AddTab(sff, "Buscar Fretes", false);
        }

        private void DesktopForm_Shown(object sender, EventArgs e)
        {
            string greeting;
            DateTime now = user.Now();
            user s = Singleton.getUser();
            List<logins> listL = logins.Fetch("SELECT date FROM logins WHERE user_id=@0 ORDER BY id DESC LIMIT 2", s.id);
            if (now.Hour >= 6 && now.Hour < 12)
                greeting = "Bom dia ";
            else if (now.Hour >= 12 && now.Hour < 18)
                greeting = "Boa tarde ";
            else
                greeting = "Boa noite ";
            greeting += String.Format("{0}, seu ultimo acesso foi em: {1:dd/MM/yyyy} as {1:HH:mm:ss}",
                s.full_name, listL.Count > 1 ? listL[1].date : now);
            lbStatusUser.Caption = greeting;

            int DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);

            if (now.Day <= 10)
            {
                lbWarings.Caption = String.Format("Lembre-se ja estamos no dia {0:dd/MM}, o movimento do mês {1:MM} já esta com o contador?", 
                    now, now.AddMonths(-1));
                if (now.Day == 10)
                    XtraMessageBox.Show("Ultimo dia para o movimento mensal estar com o contador!");
            }
            else if ((DaysInMonth - 7) <= now.Day)
            {
                lbWarings.Caption = String.Format("Lembre-se ja estamos no dia {0:dd/MM}, os CT-e's deste mês ja estão todos prontos?", now);
                if (DaysInMonth == now.Day)
                    XtraMessageBox.Show("Ultimo dia do mês, os CT-e's ja estão todos prontos?");
            }
            else
                lbWarings.Caption = String.Format(@"Nenhum aviso para hoje! :\");           
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(PleaseWaitForm), false, false, false);
            ConnectionUtil conn = new ConnectionUtil();
            string file = String.Format(@"{0}\Utils\CTPG\CTPG.exe", Directory.GetCurrentDirectory());
            string args = String.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\"", conn.Host, conn.Port, conn.User, conn.Password, conn.DataBase);
            int exit = RunUtil.Run(file, args, true);
            SplashScreenManager.CloseForm(false);
            if (exit != 0)
            {                
                XtraMessageBox.Show("Ocorre um erro na tentativa de executar o backup, ou o mesmo foi cancelado pelo usuário!");
            }
            else
            {
                XtraMessageBox.Show("Concluído com sucesso, verifique se o arquivo de backup foi criado!");
            }
        }

        private void btnChooseColor_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChooseColorFocusedForm ccff = new ChooseColorFocusedForm();
            ccff.ShowDialog();
        }

        private void tabControl_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchCNPJ_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchCNPJForm scf = new SearchCNPJForm();
            AddTab(scf, "Pesquisar Cadastro de CNPJ", false);
        }

        private void btnNewAccountToPay_ItemClick(object sender, ItemClickEventArgs e)
        {
            AccountsToPayForm atpf = new AccountsToPayForm(null);
            AddTab(atpf, "Nova Conta a Pagar", false);
        }

        private void btnSearchAccountsToPay_ItemClick(object sender, ItemClickEventArgs e)
        {            
        }

        private void btnEmitterReceipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            SingleReceipt sr = new SingleReceipt();
            AddTab(sr, "Emitir Recibo Avulso", false);
        }

        private void btnWaringsPayments_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new WaringsPaymentsDayForm(), "Pagamentos", true);
        }

        private void btnNewPayment_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new PaymentForm(null), "Novo Pagamento", false);
        }
        private void btnSearchPayments_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new SearchPaymentsForm(), "Pesquisar Pagamentos", false);
        }

        private void btnFeesDrivers_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChooseDriverFeesReport cdfr = new ChooseDriverFeesReport();
            cdfr.ShowDialog();
        }

        private void btnFreightOfTrucks_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChooseTruckFreightsReportForm ctf = new ChooseTruckFreightsReportForm();
            ctf.ShowDialog();
        }       

        private void btnOpenReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*OpenFileDialog opd = new OpenFileDialog();
            DialogResult rs = opd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                FileStream s = new FileStream(opd.FileName, FileMode.Open);
                ReportPrintTool tool = new ReportPrintTool(XtraReport.FromStream(s, true));
                SplashScreenManager.CloseForm(false);
                tool.ShowRibbonPreviewDialog();
            }
            */
        }

        private void btnManagerTrailers_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new TrailerForm(null), "Gerenciar Reboques", false);
        }

        private void btnConfigurePathFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.SelectedPath = INI.ReadValue("FILES", "CurrentPathFiles");
                DialogResult rs = fbd.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    INI.WriteValue("FILES", "CurrentPathFiles", fbd.SelectedPath);
                    Program.configureFiles();
                    XtraMessageBox.Show("Path configurado com sucesso!", "Arquivos");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocorreu um erro.\n" + ex.Message, "Erro");
            }
        }

        private void btnViewEditBusiness_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchBusinessForm sbf = new SearchBusinessForm();
            sbf.ShowDialog();
        }        
    }
}