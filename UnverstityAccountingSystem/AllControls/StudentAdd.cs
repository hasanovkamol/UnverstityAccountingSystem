using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            studentModel.EducationalDirectionSt = cobEducationalDirection.SelectedItem.ToString();
            studentModel.PaymentAgreement = checkPaymentAgreement.Checked;
            studentModel.Scholarship = chackScholarship.Checked;

        }
        private void BindView()
        {
            tbFName.Text=studentModel.Name;
            tbSName.Text= studentModel.Surname;
            studentModel.Course = int.Parse(cobCourse.SelectedItem.ToString());
            studentModel.FacultetSt = cobFacultet.SelectedItem.ToString();
            studentModel.EducationalDirectionSt = cobEducationalDirection.SelectedItem.ToString();
            checkPaymentAgreement.Checked= studentModel.PaymentAgreement;
            chackScholarship.Checked= studentModel.Scholarship;
        }

        private void btnAddFacultet_Click(object sender, EventArgs e)
        {

        }
    }
}
