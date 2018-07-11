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

namespace TruckSystem.UI.Freights
{
    public partial class SelectTrailersFreight : DevExpress.XtraEditors.XtraForm
    {
        public List<trailer> listTrailers = new List<trailer>();
        public SelectTrailersFreight()
        {
            InitializeComponent();
            bdgTrailes.DataSource = trailer.Fetch("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count > 0)
            {
                if (bdgSelectedTrailes.Count >= 3)
                {
                    XtraMessageBox.Show("O numero máximo de placas permitido são 3!");
                    return;
                }

                trailer t = (trailer)bdgTrailes.Current;
                if(!bdgSelectedTrailes.Contains(t))
                {
                    bdgSelectedTrailes.Add(t);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxSelected.SelectedItems.Count > 0)
                bdgSelectedTrailes.RemoveCurrent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (trailer t in bdgSelectedTrailes.List)
            {
                listTrailers.Add(t);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tfSearch_EditValueChanged(object sender, EventArgs e)
        {
            bdgTrailes.DataSource = trailer.Fetch("WHERE board ILIKE @0", trailer.Concat(tfSearch.EditValue));
        }
    }
}