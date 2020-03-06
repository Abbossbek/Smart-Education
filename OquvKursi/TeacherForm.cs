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
    public partial class TeacherForm : Form
    {
        public Teacher Teacher { get; set; }

        public event EventHandler GetTeacher;
        public virtual void OnGetTeacher(EventArgs e)
        {
            if (GetTeacher != null)
                GetTeacher(this, e);
        }
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = new Teacher
                {
                    Address = txtAddress.Text,
                    LastName = txtLastName.Text,
                    Name = txtName.Text,
                    SurName = txtSurName.Text,
                    PasportNumber = txtPasportNumber.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Salary = Convert.ToDouble(txtSalary.Text)
                };


                Teacher = teacher;
                this.OnGetTeacher(e);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
