using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using UnverstityAccountingSystem.AllWindows;

namespace UnverstityAccountingSystem.AllControls
{
    public partial class StudentView : System.Windows.Forms.UserControl
    {
        public StudentView()
        {
            InitializeComponent(); 
            Refresh();
        }
        private void Refresh()
        {
           dgStudent.DataSource=GloblMain.dbo.StudentDMs.ToList();
        }
        private void AddStudent_Click(object sender, EventArgs e)
        {
            AddOrUpdaetStudent student = new AddOrUpdaetStudent();
            student.ShowDialog();
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgStudent.SelectedCells[0].FormattedValue.ToString());
            var studentModel = GloblMain.dbo.StudentDMs.Find(id);
            AddOrUpdaetStudent student = new AddOrUpdaetStudent(studentModel);
            student.ShowDialog();
            Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void StudentContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgStudent.SelectedCells[0].FormattedValue.ToString());
            var studentModel = GloblMain.dbo.StudentDMs.Find(id);
            if(studentModel!=null)
            {
                if (studentModel.PaymentAgreement)
                {
                    MessageBox.Show("Этот студент поступил на основании государственного гранта.");
                    PaymentStudent payment = new PaymentStudent(studentModel);
                    payment.ShowDialog();
                    if (payment.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Платеж произведен");                      
                    }
                }
                else
                {
                    PaymentStudent payment = new PaymentStudent(studentModel);
                    payment.ShowDialog();
                    if (payment.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Платеж произведен");
                      
                    }
                }
                Refresh();
            }
           
        }
    }
}
