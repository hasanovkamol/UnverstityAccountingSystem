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
    public partial class Student : System.Windows.Forms.UserControl
    {
        public Student()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            StudentAdd student = new StudentAdd();
            GloblMain.showControl(student, StudentContent);
        }
    }
}
