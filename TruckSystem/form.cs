using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckSystem.Utils;

namespace TruckSystem
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            textEdit1.SelectAll();
            textEdit1.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            WebCEP wp = new WebCEP(textEdit1.EditValue.ToString(), WebCEP.TypeCase.Lower);
            Console.WriteLine(wp.UF);
            Console.WriteLine(wp.CIDADE);
            Console.WriteLine(wp.BAIRRO);
            Console.WriteLine(wp.TIPOLAGRADOURO);
            Console.WriteLine(wp.LAGRADOURO);
            Console.WriteLine(wp.RESULTADO);
            Console.WriteLine(wp.RESULTADO_TXT);

            textEdit1.SelectAll();
            textEdit1.Focus();
        }
    }
}
