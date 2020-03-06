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
using System.IO;
using SmartEducation;

namespace OquvKursi
{
    public partial class Form1 : Form
    {
        string file_pathAbit = "DataAbiturient.txt";
        string file_pathTeach = "DataTeacher.txt";
        string file_pathSub = "DataSubject.txt";
        string file_pathCourse = "DataCourse.txt";
        Teacher[] teachers = null;
        Subject[] subjects = null;
        Abiturient[] abiturients = null;
        Course[] courses = null;
        public Form1()
        {
            InitializeComponent();
            DataRead(dgvAbiturient, file_pathAbit);
            DataRead(dgvTeacher, file_pathTeach);
            DataRead(dgvSubject, file_pathSub);
            DataRead(dgvCourse, file_pathCourse);
            DataFill(dgvTeacher);
            DataFill(dgvSubject);
        }

        void DataRead(DataGridView dgv, string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string str;

                    while ((str = sr.ReadLine()) != null)
                    {
                        dgv.Rows.Add(str.Split('#'));
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        void DataFill(DataGridView dgv)
        {
            if (dgv == dgvTeacher)
            {
                teachers = new Teacher[dgv.Rows.Count];
                int i = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    teachers[i] = new Teacher();
                    teachers[i].Id = Convert.ToInt32(row.Cells[clmIdT.Name].Value.ToString());
                    teachers[i].Address = row.Cells[clmAddressT.Name].Value.ToString();
                    teachers[i].LastName = row.Cells[clmLastNameT.Name].Value.ToString();
                    teachers[i].Name = row.Cells[clmNameT.Name].Value.ToString();
                    teachers[i].SurName = row.Cells[clmSurNameT.Name].Value.ToString();
                    teachers[i].PasportNumber = row.Cells[clmPasportNumberT.Name].Value.ToString();
                    teachers[i].PhoneNumber = row.Cells[clmPhoneNumberT.Name].Value.ToString();
                    teachers[i].Salary = Convert.ToDouble(row.Cells[clmSalaryT.Name].Value.ToString());
                    i++;
                }
            }
            else if ( dgv == dgvSubject)
            {
                subjects = new Subject[dgv.Rows.Count];
                int i = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    subjects[i] = new Subject();
                    subjects[i].Id = Convert.ToInt32(row.Cells[clmIdS.Name].Value.ToString());
                    subjects[i].Name = row.Cells[clmNameS.Name].Value.ToString();
                    subjects[i].Price = Convert.ToDouble(row.Cells[clmPrice.Name].Value.ToString());
                    i++;
                }
            }
            else if (dgv == dgvCourse)
            {

                courses = new Course[dgv.Rows.Count];
                int i = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    courses[i] = new Course();
                    courses[i].Id = Convert.ToInt32(row.Cells[clmIdC.Name].Value.ToString());
                    courses[i].Name = row.Cells[clmCourseNameC.Name].Value.ToString();
                    courses[i].TeacherId = Convert.ToInt32(row.Cells[clmTeacherC.Name].Value.ToString());
                    courses[i].SubjectId = Convert.ToInt32(row.Cells[clmSubjectC.Name].Value.ToString());
                    i++;
                }
            }      
                    
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (sender == mnuNewTeacher || sender == tsmnuTeacher)
            {
                TeacherForm frmTeacher = new TeacherForm();
                frmTeacher.GetTeacher += frmTeacher_GetTeacher;
                frmTeacher.ShowDialog();
            }
            else if (sender == mnuNewSubject || sender == tsmnuNewSubject)
            {
                SubjectForm frmSubject = new SubjectForm();
               frmSubject.GetSubject +=frmSubject_GetSubject;
               frmSubject.ShowDialog();
            }
            else if (sender == mnuNewAbiturient || sender == tsmnuNewAbiturient)
            {
                AbiturientForm frmAbit = new AbiturientForm();
                frmAbit.GetAbiturient += frmAbit_GetAbiturient;
                frmAbit.ShowDialog();
            }
            else if (sender == mnuNewCourse || sender == tsmnuCourse)
            {
                CourseForm frmCourse = new CourseForm(subjects, teachers);
                frmCourse.GetCourse += frmCourse_GetCourse;
                frmCourse.ShowDialog();
                
            }
            else if (sender == mnuSave || sender == tsmnuSave)
            {
                SaveInformation(dgvAbiturient, file_pathAbit);
                SaveInformation(dgvTeacher, file_pathTeach);
                SaveInformation(dgvSubject, file_pathSub);
                SaveInformation(dgvCourse, file_pathCourse);
            }
        }

        void frmCourse_GetCourse(object sender, EventArgs e)
        {
            var a = ((CourseForm)sender).Course;

            string TeacherName = "";
            string FanName = "";
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i].Id == a.TeacherId)
                {
                    TeacherName = teachers[i].LastName + " " + teachers[i].Name;
                }
            }
            for (int i = 0; i < subjects.Length; i++)
            {
                if (subjects[i].Id == a.SubjectId)
                {
                    FanName = subjects[i].Name;
                }
            }

                dgvCourse.Rows.Add(1, a.Name, TeacherName,FanName);           
        }

        void SaveInformation(DataGridView dgv, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    string str = "";

                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            str += row.Cells[i].Value.ToString() + "#";
                        }
                        else
                        {
                            str += " #";
                        }
                    }
                    str = str.Remove(str.Length - 1, 1);

                    sw.WriteLine(str);
                }
            }       
        }

        void frmSubject_GetSubject(object sender, EventArgs e)
        {
            int idSubject = 0;
            if (dgvSubject.Rows.Count > 0)
            {
                idSubject = Convert.ToInt32(dgvSubject.Rows[dgvSubject.Rows.Count - 1].Cells[clmIdS.Name].Value.ToString());
            }

            var a = ((SubjectForm)sender).Subject;
            dgvSubject.Rows.Add(idSubject+1, a.Name,a.Price);
           
          
        }

        void frmTeacher_GetTeacher(object sender, EventArgs e)
        {
            int idTeacher = 0;
            if (dgvTeacher.Rows.Count > 0)
            {
                idTeacher = Convert.ToInt32(dgvTeacher.Rows[dgvTeacher.Rows.Count - 1].Cells[clmIdT.Name].Value.ToString());
            }
            var a = ((TeacherForm)sender).Teacher;
            dgvTeacher.Rows.Add(idTeacher+1, a.LastName, a.Name, a.SurName, a.PasportNumber, a.Address, a.PhoneNumber, a.Salary);
          
        }

        void frmAbit_GetAbiturient(object sender, EventArgs e)
        {
            int idAbiturient = 0;
            if (dgvAbiturient.Rows.Count > 0)
            {
                idAbiturient = Convert.ToInt32(dgvAbiturient.Rows[dgvAbiturient.Rows.Count - 1].Cells[clmId.Name].Value.ToString());
            }
            var a = ((AbiturientForm)sender).Abiturient;
            dgvAbiturient.Rows.Add(idAbiturient+1, a.LastName, a.Name, a.SurName, a.PasportNumber, a.Address, a.PhoneNumber, a.Reyting);
                     
        }

        private void dgvAbiturient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAbiturient_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = 0;
            while (i < dgvAbiturient.Rows.Count)
            {
                if (dgvAbiturient.Rows[i].Cells[4].Selected)
                {
                    AccountForm frmAccount = new AccountForm(dgvAbiturient.Rows[i]);
                    frmAccount.ShowDialog();
                }
                i++;
            }
        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }


       

        
    }
}
