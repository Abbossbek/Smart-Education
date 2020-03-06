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
    public partial class CourseForm : Form
    {
        int subjectId = -1;
        int teacherId = -1;

        
        public Course Course { get; set; }

        public event EventHandler GetCourse;
        public virtual void OnGetCourse(EventArgs e)
        {
            if (GetCourse != null)
                GetCourse(this, e);
        }
        public CourseForm()
        {
            InitializeComponent();
        }

        public CourseForm(Subject[] subjects, Teacher[] teachers)
        {            
            InitializeComponent();
            FillComboBox(teachers,subjects);
        }

        void FillComboBox(Teacher[] teachers,  Subject[] subjects)
        {
            cmbTeacher.DataSource = teachers;
            cmbTeacher.DisplayMember = "LastName";
            cmbTeacher.ValueMember = "Id";

            cmbFan.DataSource = subjects;
            cmbFan.DisplayMember = "Name";
            cmbFan.ValueMember = "Id";
            
            //int i=0;
            //foreach (var item in teachers)
            //{
            //    string fullName = item.LastName + " " + item.Name[0] + "." + item.SurName[0] + ".";
            //    int id = item.Id;
            //    cmbTeacher.

            //}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (subjectId != -1 && teacherId != -1)
                {
                    var course = new Course
                    {
                        Name = txtName.Text,
                        TeacherId = teacherId,
                        SubjectId = subjectId
                    };


                    Course = course;
                    this.OnGetCourse(e);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }

        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == cmbTeacher)
            {
                teacherId = (int)((Teacher)cmbTeacher.SelectedItem).Id;

            }
            else if (sender == cmbFan)
            {
                subjectId = (int)((Subject)cmbFan.SelectedItem).Id;
            }

        }
    }
}
