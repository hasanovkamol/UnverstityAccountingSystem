using EntityModel.Data;
using EntityModel.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnverstityAccountingSystem.AllWindows
{
    public partial class UserRegistration : Form
    {
        User user = new User();
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void tbCreate_Click(object sender, EventArgs e)
        {

        }
        private void BindMode()
        {
            user.Login = tbLogin.Text;
            user.Password = tbpassword.Text;
            user.UserName = tbUsername.Text;
            user.UserRoll = GloblMain.ConvertFromEnumIntoString(tbSelectRol.SelectedItem.ToString());
        }
    }
}
