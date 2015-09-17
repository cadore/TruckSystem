namespace TruckSystem.UI
{
    partial class DesktopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnManagerAccountants = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewDriver = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchDriver = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewTruck = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchTrucks = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewGasStation = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchGasStations = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewAccountToPay = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchAccountsToPay = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewFreight = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchFreights = new DevExpress.XtraBars.BarButtonItem();
            this.lbStatusUser = new DevExpress.XtraBars.BarStaticItem();
            this.lbWarings = new DevExpress.XtraBars.BarStaticItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnChooseColor = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchCNPJ = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnNewCustomer,
            this.btnSearchCustomer,
            this.btnManagerAccountants,
            this.btnNewDriver,
            this.btnSearchDriver,
            this.btnNewTruck,
            this.btnSearchTrucks,
            this.btnNewGasStation,
            this.btnSearchGasStations,
            this.btnNewAccountToPay,
            this.btnSearchAccountsToPay,
            this.btnNewFreight,
            this.btnSearchFreights,
            this.lbStatusUser,
            this.lbWarings,
            this.btnBackup,
            this.btnChooseColor,
            this.btnSearchCNPJ});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 26;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage2,
            this.ribbonPage4});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1002, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Novo  Usuário";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Buscar Usuários";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Caption = "Novo  Cliente";
            this.btnNewCustomer.Id = 3;
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewCustomer_ItemClick);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Caption = "Buscar Clientes";
            this.btnSearchCustomer.Id = 4;
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchCustomer_ItemClick);
            // 
            // btnManagerAccountants
            // 
            this.btnManagerAccountants.Caption = "Gerenciar Contas";
            this.btnManagerAccountants.Id = 5;
            this.btnManagerAccountants.Name = "btnManagerAccountants";
            this.btnManagerAccountants.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnManagerAccountants.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnManagerAccountants_ItemClick);
            // 
            // btnNewDriver
            // 
            this.btnNewDriver.Caption = "Novo  Motorista";
            this.btnNewDriver.Id = 6;
            this.btnNewDriver.Name = "btnNewDriver";
            this.btnNewDriver.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewDriver.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewDriver_ItemClick);
            // 
            // btnSearchDriver
            // 
            this.btnSearchDriver.Caption = "Buscar Motoristas";
            this.btnSearchDriver.Id = 7;
            this.btnSearchDriver.Name = "btnSearchDriver";
            this.btnSearchDriver.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchDriver.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchDriver_ItemClick);
            // 
            // btnNewTruck
            // 
            this.btnNewTruck.Caption = "Novo  Caminhão";
            this.btnNewTruck.Id = 8;
            this.btnNewTruck.Name = "btnNewTruck";
            this.btnNewTruck.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewTruck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewTruck_ItemClick);
            // 
            // btnSearchTrucks
            // 
            this.btnSearchTrucks.Caption = "Buscar Caminhões";
            this.btnSearchTrucks.Id = 9;
            this.btnSearchTrucks.Name = "btnSearchTrucks";
            this.btnSearchTrucks.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchTrucks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchTrucks_ItemClick);
            // 
            // btnNewGasStation
            // 
            this.btnNewGasStation.Id = 22;
            this.btnNewGasStation.Name = "btnNewGasStation";
            // 
            // btnSearchGasStations
            // 
            this.btnSearchGasStations.Id = 23;
            this.btnSearchGasStations.Name = "btnSearchGasStations";
            // 
            // btnNewAccountToPay
            // 
            this.btnNewAccountToPay.Caption = "Nova Conta a Pagar";
            this.btnNewAccountToPay.Id = 13;
            this.btnNewAccountToPay.Name = "btnNewAccountToPay";
            this.btnNewAccountToPay.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewAccountToPay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewAccountToPay_ItemClick);
            // 
            // btnSearchAccountsToPay
            // 
            this.btnSearchAccountsToPay.Caption = "Buscar Contas a Pagar";
            this.btnSearchAccountsToPay.Id = 14;
            this.btnSearchAccountsToPay.Name = "btnSearchAccountsToPay";
            this.btnSearchAccountsToPay.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnNewFreight
            // 
            this.btnNewFreight.Caption = "Novo  Frete";
            this.btnNewFreight.Id = 15;
            this.btnNewFreight.Name = "btnNewFreight";
            this.btnNewFreight.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewFreight.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewFreight_ItemClick);
            // 
            // btnSearchFreights
            // 
            this.btnSearchFreights.Caption = "Buscar Fretes";
            this.btnSearchFreights.Id = 16;
            this.btnSearchFreights.Name = "btnSearchFreights";
            this.btnSearchFreights.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchFreights.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchFreights_ItemClick);
            // 
            // lbStatusUser
            // 
            this.lbStatusUser.Caption = "lbStatusUser";
            this.lbStatusUser.Id = 18;
            this.lbStatusUser.Name = "lbStatusUser";
            this.lbStatusUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbWarings
            // 
            this.lbWarings.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbWarings.Caption = "lbWarings";
            this.lbWarings.Id = 19;
            this.lbWarings.Name = "lbWarings";
            this.lbWarings.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Backup";
            this.btnBackup.Id = 20;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Caption = "Cor de fundo dos Campos de Texto";
            this.btnChooseColor.Id = 21;
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnChooseColor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChooseColor_ItemClick);
            // 
            // btnSearchCNPJ
            // 
            this.btnSearchCNPJ.Caption = "Pesquisar Cadastro CNPJ";
            this.btnSearchCNPJ.Id = 25;
            this.btnSearchCNPJ.Name = "btnSearchCNPJ";
            this.btnSearchCNPJ.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchCNPJ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchCNPJ_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Gestão";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewFreight);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSearchFreights);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Fretes";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNewAccountToPay);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSearchAccountsToPay);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Pagamentos";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Cadastros";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnNewCustomer);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSearchCustomer);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSearchCNPJ);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Clientes";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnNewDriver);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnSearchDriver);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Motoristas";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.btnNewTruck);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnSearchTrucks);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            this.ribbonPageGroup7.Text = "Caminhões";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnManagerAccountants);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Contas Bancarias";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Administração";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Usuários";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Sistema";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.AllowTextClipping = false;
            this.ribbonPageGroup9.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.ShowCaptionButton = false;
            this.ribbonPageGroup9.Text = "Banco de Dados";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.AllowTextClipping = false;
            this.ribbonPageGroup10.ItemLinks.Add(this.btnChooseColor);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.ShowCaptionButton = false;
            this.ribbonPageGroup10.Text = "Personalização";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lbStatusUser);
            this.ribbonStatusBar.ItemLinks.Add(this.lbWarings);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 492);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1002, 31);
            // 
            // tabControl
            // 
            this.tabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.tabControl.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close, "", -1, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, serializableAppearanceObject1, "", 1, null, true)});
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 144);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1002, 348);
            this.tabControl.TabIndex = 2;
            this.tabControl.CloseButtonClick += new System.EventHandler(this.tabControl_CloseButtonClick);
            this.tabControl.CustomHeaderButtonClick += new DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventHandler(this.tabControl_CustomHeaderButtonClick);
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            this.tabControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlAdded);
            this.tabControl.Resize += new System.EventHandler(this.tabControl_Resize);
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 523);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.KeyPreview = true;
            this.Name = "DesktopForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Truck System - Cadore Tecnologia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesktopForm_FormClosing);
            this.Shown += new System.EventHandler(this.DesktopForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnNewCustomer;
        private DevExpress.XtraBars.BarButtonItem btnSearchCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        public DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraBars.BarButtonItem btnManagerAccountants;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnNewDriver;
        private DevExpress.XtraBars.BarButtonItem btnSearchDriver;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnNewTruck;
        private DevExpress.XtraBars.BarButtonItem btnSearchTrucks;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnNewGasStation;
        private DevExpress.XtraBars.BarButtonItem btnSearchGasStations;
        private DevExpress.XtraBars.BarButtonItem btnNewAccountToPay;
        private DevExpress.XtraBars.BarButtonItem btnSearchAccountsToPay;
        private DevExpress.XtraBars.BarButtonItem btnNewFreight;
        private DevExpress.XtraBars.BarButtonItem btnSearchFreights;
        private DevExpress.XtraBars.BarStaticItem lbStatusUser;
        private DevExpress.XtraBars.BarStaticItem lbWarings;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnChooseColor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnSearchCNPJ;
    }
}