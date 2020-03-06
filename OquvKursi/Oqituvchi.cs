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
    public partial class Oqituvchi : Form
    {
        public string Name { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }
        public string Jins { get; set; }
        public event EventHandler GetOqituvchi;
        public virtual void OnGetOqituvchi(EventArgs e)
        {
            if (GetOqituvchi != null)
                GetOqituvchi(this, e);
        }
        public Oqituvchi()
        {
            InitializeComponent();
        }
         public Oqituvchi(ToolStripComboBox tscmb)
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
                 Name = this.txtName.Text;
                 lastName = this.txtLastName.Text;
                 Age = Int32.Parse(this.txtAge.Text);
                 Subject = this.cmbFan.SelectedItem.ToString();
                 Jins = this.rbErkak.Checked ? "Erkak" : this.rbAyol.Checked ? "Ayol" : "";
                 this.OnGetOqituvchi(e);
                 this.Close();
             }
             catch { }
         }
    }
}
