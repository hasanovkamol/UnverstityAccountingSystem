using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnverstityAccountingSystem.Data;

namespace UnverstityAccountingSystem.AllWindows
{
    public partial class UserRollAcount : Form
    {
        public UserRollAcount()
        {
            InitializeComponent();
            Refresh();
        }

        private void UserRollAcount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            РегистрацияОрганизации regOrg = new РегистрацияОрганизации();
            regOrg.Show();
        }
        private void Refresh()
        {
            dgAccount.DataSource =GloblMain.dbo.Users.ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            UserRegistration user = new UserRegistration();
            user.ShowDialog();
            if (user.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgAccount.SelectedCells[0].FormattedValue.ToString());
            var _user=GloblMain.dbo.Users.Find(id);
            UserRegistration user = new UserRegistration((User)_user);
            user.ShowDialog();
            if (user.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgAccount.SelectedCells[0].FormattedValue.ToString());
            var _user = GloblMain.dbo.Users.Find(id);
            GloblMain.dbo.Users.Remove(_user);
            GloblMain.dbo.SaveChanges();
            MessageBox.Show("Удалить пользователя", _user.UserName);
            Refresh();
        }
    }
}
