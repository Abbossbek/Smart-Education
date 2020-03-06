using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OquvKursi.Models;
namespace OquvKursi
{
    public partial class SubjectForm : Form
    {
        public Subject Subject { get; set; }

        public event EventHandler GetSubject;
        public virtual void OnGetSubject(EventArgs e)
        {
            if (GetSubject != null)
                GetSubject(this, e);
        }
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = new Subject
                {
                    Name = txtSubject.Text,
                    Price = Convert.ToDouble(txtPrice.Text)
                };


                Subject = subject;
                this.OnGetSubject(e);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
