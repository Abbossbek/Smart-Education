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
    
    public partial class Fan : Form
    {
        public string Subject { get; set; }
        public event EventHandler GetFan;
        public virtual void OnGetFan(EventArgs e)
        {
            if (GetFan != null)
                GetFan(this, e);
        }
        public Fan()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSubject.Text!="")
                Subject = this.txtSubject.Text;
                this.OnGetFan(e);
                this.Close();
            }
            catch { }
        }
    }
}
