using System;
using System.Windows.Forms;

namespace UnverstityAccountingSystem.AllWindows
{
    public partial class RegistrationUser :Form
    {
        public RegistrationUser()
        {
            InitializeComponent();
        }

        private void RegistrationUser_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            РегистрацияОрганизации regOrg = new РегистрацияОрганизации();
            regOrg.Show();

            //BankAccount bankAccount = new BankAccount();
            //bankAccount.Show();

            //Valuta valuta = new Valuta();
            //valuta.Show();

            //Bank bank = new Bank();
            //bank.Show();
            //РегистрацияОрганизации registr = new РегистрацияОрганизации();
            //registr.Show();
            this.Hide();
        }
    }
}
