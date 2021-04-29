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
           //dgStudent.DataSource=GloblMain.dbo.Students.ToList();
        }
        private void AddStudent_Click(object sender, EventArgs e)
        {
            StudentAdd student = new StudentAdd();
            GloblMain.showControl(student, StudentContent);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgStudent.SelectedCells[0].FormattedValue.ToString());
            var studentModel = GloblMain.dbo.Students.Find(id);
            StudentAdd student = new StudentAdd(studentModel);
            GloblMain.showControl(student, StudentContent);
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
    }
}
