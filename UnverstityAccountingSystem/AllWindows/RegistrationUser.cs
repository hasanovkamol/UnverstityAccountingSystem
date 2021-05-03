using System;
using System.Linq;
using System.Windows.Forms;

namespace UnverstityAccountingSystem.AllWindows
{
    public partial class RegistrationUser :Form
    {
        public RegistrationUser()
        {
            InitializeComponent();
            if (GloblMain.dbo.GetОrganizations.ToList().Count() > 0) linkLabel2.Enabled = true;
            else linkLabel2.Enabled = false;
        }

        private void RegistrationUser_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var _user = GloblMain.SingIn(tnLogin.Text, tbPassowrd.Text);
            if (_user != null)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else tbError.Text = "Пользователь не найден";
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FindOrganization()) tbError.Text = "Организация зарегистрирована";
            else
            {
                РегистрацияОрганизации regOrg = new РегистрацияОрганизации();
                regOrg.Show();
                this.Hide();
            }

        }
        private bool FindOrganization()
        {
           return GloblMain.dbo.GetОrganizations.ToList().Count>0? true :false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          DialogResult dialog= MessageBox.Show("Вы действительно хотите удалить базу данных"
              ,"Удалить"
              , MessageBoxButtons.YesNo
              ,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                int id = GloblMain.dbo.GetОrganizations.ToList().FirstOrDefault().OrganizationId;
                GloblMain.dbo.GetОrganizations.Remove(GloblMain.dbo.GetОrganizations.Find(id));
                GloblMain.dbo.SaveChanges();

            }
            else
            {

            }
            if (GloblMain.dbo.GetОrganizations.ToList().Count() > 0) linkLabel2.Enabled = true;
            else linkLabel2.Enabled = false;


        }
    }
}
