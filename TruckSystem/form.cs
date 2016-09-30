using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckSystem
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate(@"http://consultapublicarntrc.antt.gov.br/consultapublica");

            string theURI = "http://consultapublicarntrc.antt.gov.br/consultapublica";
            string theFrame = "";
            System.Text.ASCIIEncoding anEncoder = new ASCIIEncoding();
            byte[] HTTPPostData = anEncoder.GetBytes("");
            string additionalHeaders = "Content-Type: application/x-www-form-urlencoded\n\r";
            webBrowser1.Navigate(theURI, theFrame, HTTPPostData, additionalHeaders);
        }
    }
}
