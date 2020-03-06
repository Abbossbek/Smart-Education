using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OquvKursi
{
    public partial class Kurs : Form
    {
        public string Fan { get; set; }
        public string Kun { get; set; }
        public string Soat { get; set; }
        public event EventHandler GetKurs;
        public virtual void OnGetKurs(EventArgs e)
        {
            if (GetKurs != null)
                GetKurs(this, e);
        }
        public Kurs()
        {
            InitializeComponent();
        }
        public Kurs(ToolStripComboBox tscmb)
        {
            InitializeComponent();
            foreach (var a in tscmb.ComboBox.Items)
            {
                cmbFan.Items.Add(a);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                Fan = cmbFan.SelectedItem.ToString();
                Soat = txtSoat.Text;
                Kun = rbJuft.Checked ? "Juft kunlar" : rbToq.Checked ? "Toq kunlar" : "";
                this.OnGetKurs(e);
                this.Close();
            }
            catch
            {

            }
        }
    }
}
