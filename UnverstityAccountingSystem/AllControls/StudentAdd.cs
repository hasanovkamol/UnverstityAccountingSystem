using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnverstityAccountingSystem.AllWindows;

namespace UnverstityAccountingSystem.AllControls
{
    public partial class StudentAdd : UserControl
    {
        UnverstityAccountingSystem.Data.Student studentModel = new UnverstityAccountingSystem.Data.Student();
        public StudentAdd(UnverstityAccountingSystem.Data.Student  student=null)
        {
            InitializeComponent();
            if(student!=null)
            {
                this.studentModel = student;
                BindView();
            }
            cobFacultet.Items.Clear();
            foreach (var item in GloblMain.dbo.Facultets.ToList())
            {
                cobFacultet.Items.Add(item.Name);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            GloblMain.showControl(student, Content);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BindModel();
            if (studentModel.NotNullModel())
            {
                studentModel.ApplyChanges();
                Student student = new Student();
                GloblMain.showControl(student, Content);
            }
            else tbError.Text = "Введите данные полностью ";


        }
        private void BindModel()
        {
            studentModel.Name = tbFName.Text;
            studentModel.Surname = tbSName.Text;
            studentModel.Course = int.Parse(cobCourse.SelectedItem.ToString());
            studentModel.FacultetSt = cobFacultet.SelectedItem.ToString();
            studentModel.EducationalDirectionSt = cobDirection.SelectedItem.ToString();
            studentModel.PaymentAgreement = checkPaymentAgreement.Checked;
            studentModel.Scholarship = chackScholarship.Checked;

        }
        private void BindView()
        {
            tbFName.Text=studentModel.Name;
            tbSName.Text= studentModel.Surname;
            cobCourse.SelectedItem = studentModel.Course;
            cobFacultet.SelectedItem = studentModel.FacultetSt;
            cobDirection.SelectedItem = studentModel.EducationalDirectionSt;
            checkPaymentAgreement.Checked= studentModel.PaymentAgreement;
            chackScholarship.Checked= studentModel.Scholarship;
        }

        private void btnAddFacultet_Click(object sender, EventArgs e)
        {
            FacultetView facultetView = new FacultetView();
            facultetView.ShowDialog();
            cobFacultet.Items.Clear();
            foreach (var item in GloblMain.dbo.Facultets.ToList())
            {
                cobFacultet.Items.Add(item.Name);
            }
        }

        private void cobFacultet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cobFacultet.Items.Count == 0) return;
            else
            {
                cobDirection.Items.Clear();
                int id = FindFacultet(cobFacultet.SelectedItem.ToString());
                foreach (var item in GloblMain.dbo.Directions.ToList().Where(x => x.FacultetId ==id))
                {
                    cobDirection.Items.Add(item.Name);
                }
            }
            
        }
        private int FindFacultet(string name)
        {
           return GloblMain.dbo.Facultets.ToList().Where(x => x.Name == name).FirstOrDefault().FacultetId;
        }
    }
}
