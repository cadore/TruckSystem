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
using System.IO;
using TruckSystem.FileManager;
using TruckSystem.Utils;
using PostgresUtil;

namespace TruckSystem.UI.Backup
{
    public partial class ConfigBackupForm : DevExpress.XtraEditors.XtraForm
    {
        string PathBackup = "";
        string PathPG = "";
        public ConfigBackupForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            PathBackup = Paths.PathBackupFile;
            PathPG = Paths.PathPG;
            tfPathBackup.EditValue = PathBackup;
            tfPathPG.EditValue = PathPG;
            GetLastBackup();
        }

        private void GetLastBackup()
        {
            try
            {
                PostgresqlUtil pg = new PostgresqlUtil() { PathOutputSqlPrimary = Paths.backups };
                DateTime dt = pg.GetLastBackup();
                tfDateLastBackup.EditValue = String.Format("{0:dd/MM/yyyy} ás {0:HH:mm:ss}", dt);
            }
            catch (Exception ex)
            {
                tfDateLastBackup.EditValue = "Não foi possivel obter o ultimo backup criado! / " + ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFindPathBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Informe o Diretório para salvar os aqruivos de Backup";
            if(!String.IsNullOrEmpty(PathBackup))
                fbd.SelectedPath = PathBackup;
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                PathBackup = fbd.SelectedPath;
                SaveConfig();
            }
        }        

        private void btnFindPathPG_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AutoUpgradeEnabled = true;
            if (!String.IsNullOrEmpty(PathPG))
                ofd.InitialDirectory = PathPG;
            ofd.Title = "Informe o local de 'pg_dump.exe'.";
            ofd.Filter = "pg_dump.exe | pg_dump.exe";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(ofd.FileName);
                PathPG = fi.DirectoryName;
                SaveConfig();
            }
        }

        private void SaveConfig()
        {
            tfPathBackup.EditValue = PathBackup;
            tfPathPG.EditValue = PathPG;

            INI.WriteValue("BACKUP", "PathBackupFile", PathBackup);
            INI.WriteValue("BACKUP", "PathPG", PathPG);

            Program.configurePathBackup();
        }
    }
}