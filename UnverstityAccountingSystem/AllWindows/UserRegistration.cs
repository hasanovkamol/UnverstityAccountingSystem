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
    public partial class UserRegistration : Form
    {
        User user = new User();
        public UserRegistration(User user=null)
        {
            InitializeComponent();
            if(user!=null)
            {
                this.user = user;
                BindView();
            }
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void tbCreate_Click(object sender, EventArgs e)
        {

            tbError.Text = "";
            if (tbpassword.Text == tbConfirmpassword.Text)
            {
                BindModel();
                if (user.NotNullModel())
                {
                    user.ApplyChanges();
                }
                else tbError.Text = "Поле пустое";
            }
            else tbError.Text = "Подтвердить Пароль";


        }
        private void BindModel()
        {
            user.Login = tbLogin.Text;
            user.Password = tbpassword.Text;
            user.UserName = tbUsername.Text;
            user.UserRoll = GloblMain.ConvertFromEnumIntoString(tbSelectRol.SelectedItem.ToString());
        }
        private void BindView()
        {
            tbLogin.Text = user.Login;
            tbpassword.Text= user.Password;
            tbUsername.Text= user.UserName;
            tbConfirmpassword.Text = user.Password;
        }
    }
}
