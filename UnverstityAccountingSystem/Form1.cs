using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using UnverstityAccountingSystem.AllControls;

namespace UnverstityAccountingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
        // Studentu for Click Event
        private void btStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            GloblMain.showControl(student, Content);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            OrganizatsionInfo organizatsion = new OrganizatsionInfo();
            GloblMain.showControl(organizatsion, Content);
        }
    }
}
