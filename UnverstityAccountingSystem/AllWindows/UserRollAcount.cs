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
    public partial class UserRollAcount : Form
    {
        public UserRollAcount()
        {
            InitializeComponent();
           
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            UserRegistration user = new UserRegistration();
            user.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
