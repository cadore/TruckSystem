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
using TruckSystem.FileManager.Models;
using TruckSystem.FileManager.Utils;
using TruckSystem.FileManager;
using TruckSystem.Utils;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace TruckSystem.FileManager.UI
{
    public partial class FileManagerForm : DevExpress.XtraEditors.XtraForm
    {
        string path_work = "";
        public FileManagerForm(Enums.TypePath tp, long id_controller)
        {
            InitializeComponent();
            path_work = getPath(tp, id_controller);    
            searchFiles();
            webBrowser.DocumentText = TruckSystem.Properties.Resources.SelectOneFile;
        }        

        private void searchFiles()
        {
            List<FileModel> list = new List<FileModel>();
            DirectoryInfo Dir = new DirectoryInfo(path_work);
            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo File in Files)
            {
                list.Add(new FileModel() { 
                    name = File.Name, extension = File.Extension,
                    size = UtilFiles.FormatSize(File.Length),
                    full_name = File.FullName
                });
            }
            bdgFile.DataSource = list;
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            pb.Properties.Maximum = (int) e.MaximumProgress;
            pb.Properties.Minimum = 0;
            pb.Position = (int)e.CurrentProgress;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bdgFile_CurrentChanged(object sender, EventArgs e)
        {
            string[] extensions = { ".pdf", ".zip", ".txt" };

            //if (((FileModel)bdgFile.Current) == null)
              //  webBrowser.DocumentText = TruckSystem.Properties.Resources.SelectOneFile;

            FileModel fm = (FileModel)bdgFile.Current;
            if (fm != null)
            {
                for (int i = 0; i < extensions.Length; i++)
                {
                    if (fm.extension == extensions[i])
                    {
                        webBrowser.Navigate(fm.full_name);
                        break;
                    }
                    else
                        //webBrowser.Navigate("about:blank");
                        webBrowser.DocumentText = TruckSystem.Properties.Resources.ErrorFile;
                    //.Navigate(TruckSystem.Properties.Resources.ErrorFile);
                }
            }
                            
        }

        string getPath(Enums.TypePath tp, long id)
        {
            string r = "";
            switch (tp)
            {
                case Enums.TypePath.business:
                    r = Path.Combine(Paths.business);
                    break;
                case Enums.TypePath.drivers:
                    r = Path.Combine(Paths.drivers, id.ToString());
                    break;
                case Enums.TypePath.trucks:
                    r = Path.Combine(Paths.trucks, id.ToString());
                    break;
                case Enums.TypePath.trailers:
                    r = Path.Combine(Paths.trailers, id.ToString());
                    break;
                case Enums.TypePath.customers:
                    r = Path.Combine(Paths.customers, id.ToString());
                    break;
                case Enums.TypePath.bank_accounts:
                    r = Path.Combine(Paths.bank_accounts, id.ToString());
                    break;
            }
            Paths.verifyPath(r);
            return r;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FileModel fm = ((FileModel)bdgFile.Current);
            if (fm != null)
            {
                webBrowser.DocumentText = TruckSystem.Properties.Resources.SelectOneFile;
                DialogResult rs = XtraMessageBox.Show("Confirma a exclusão do arquivo?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;

                try
                {
                    File.Delete(fm.full_name);
                    XtraMessageBox.Show("Arquivo excluido com sucesso!");
                    searchFiles();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Ocorreu um erro.\n" + ex.Message);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                FileModel fm = ((FileModel)bdgFile.Current);
                if(fm != null)
                    Process.Start(fm.full_name);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocorreu um erro.\n" + ex.Message);
            }
            
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                FileModel fm = ((FileModel)bdgFile.Current);
                if (fm != null)
                {
                    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Salvar arquivo";
                    sfd.AutoUpgradeEnabled = true;
                    sfd.InitialDirectory = desktop;
                    sfd.Filter = "Arquivo personalizado | " + fm.extension;
                    sfd.FilterIndex = 0;
                    sfd.FileName = fm.name;
                    sfd.RestoreDirectory = true;
                    DialogResult rs = sfd.ShowDialog();
                    if (rs == DialogResult.OK && !String.IsNullOrEmpty(sfd.FileName))
                    {
                        File.Copy(fm.full_name, sfd.FileName, true);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocorreu um erro.\n" + ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                FileModel fm = ((FileModel)bdgFile.Current);
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Carregar arquivo";
                ofd.InitialDirectory = desktop;
                ofd.Filter = "Todos os Arquivos | *.*";
                ofd.FilterIndex = 0;
                DialogResult rs = ofd.ShowDialog();
                if (rs == DialogResult.OK)
                {
                getname:
                    FileInfo fi = new FileInfo(ofd.FileName);
                    string filename = InputDialog(fi.Name.Replace(fi.Extension, ""));
                    string file = path_work + @"\" + filename + fi.Extension;
                    if (String.IsNullOrEmpty(filename))
                    {
                        XtraMessageBox.Show("Operação cancelada!");
                        return;
                    }
                    Console.WriteLine();
                    if (File.Exists(file))
                    {
                        XtraMessageBox.Show("Arquivo já existente, tente utilizar outro nome.");
                        goto getname;
                    }
                    File.Copy(ofd.FileName, file);
                    searchFiles();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocorreu um erro.\n" + ex.Message);
            }
        }
        string InputDialog(string defaul_text)
        {
            string result = Interaction.InputBox("Informe um nome para o arquivo.", "Carregar arquivo", defaul_text);
            if (result != "")
            {
                result = result.TrimStart();
            }
            return result;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            bdgFile_CurrentChanged(sender, e);
        }
    }
}
