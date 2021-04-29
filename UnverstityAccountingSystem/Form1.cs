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
using UnverstityAccountingSystem.AllWindows;

namespace UnverstityAccountingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            //tbOrg.Text += ": " + GloblMain.dbo.Students.Find(0).Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
        // Studentu for Click Event
        private void btStudent_Click(object sender, EventArgs e)
        {
            StudentView student = new StudentView();
            GloblMain.showControl(student, Content);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            OrganizatsionInfo organizatsion = new OrganizatsionInfo();
            GloblMain.showControl(organizatsion, Content);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationUser user = new RegistrationUser();
            user.Show();
            this.Hide();
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
