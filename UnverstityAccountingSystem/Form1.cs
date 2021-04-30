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
            //if (GloblMain.GetUser == null)
            //{
            //    MessageBox.Show("Пожалуйста, зарегистрируйте этого пользователя в системе ");
            //    this.Close();
            //}
            //else
            //{
            //    InitializeComponent();
            //    materialRaisedButton2_Click(null, null);
            //    tbUserName.Text = GloblMain.GetUser.UserName;
            //}
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
            OrganizatsionInfo organizatsion = new OrganizatsionInfo(GloblMain.Orientation);
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

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            PositionView positionView = new PositionView();
            GloblMain.showControl(positionView, Content);
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            EmployeeViewC viewC = new EmployeeViewC();
            GloblMain.showControl(viewC, Content);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
