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
    public partial class РегистрацияОрганизации : Form
    {
        private Оrganization GetОrganization = new Оrganization();
        public РегистрацияОрганизации(Оrganization оrganization=null)
        {
            InitializeComponent();
            if (оrganization!= null)
            {
                this.GetОrganization = оrganization;
                BindView();
                btnSave.Text = "Обновлять";
            }
        }
        private void BindView()
        {
             tbName.Text= GetОrganization.Name;
             tbINN.Text= GetОrganization.INN;
             tbAddress.Text= GetОrganization.Address;
             tbTelefon.Text= GetОrganization.Telefon;
             tbGostNumber.Text= GetОrganization.NomerGost;
             dtGostDate.Value= GetОrganization.NomerGostDate;
             dtRegistration.Value= GetОrganization.RegistrationDate;
             tbBankAccount.Text = GetОrganization.BankAccount.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.ShowDialog();
            GetОrganization.BankAccount = GloblMain.bankaccount;
            tbBankAccount.Text = GetОrganization.BankAccount.Name;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void РегистрацияОрганизации_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BindModel();
            if (GetОrganization.NotNullModel())
            {
                GetОrganization.ApplyChanges();

                if(btnSave.Text=="Обновлять") this.Hide();
                else
                {
                    UserRollAcount userRoll = new UserRollAcount();
                    userRoll.Show();
                }
                this.Hide();
            }
            else tbError.Text = "Информация неполная ";

        }
        private void BindModel()
        {
            GetОrganization.Name = tbName.Text;
            GetОrganization.INN = tbINN.Text;
            GetОrganization.Address = tbAddress.Text;
            GetОrganization.Telefon = tbTelefon.Text;
            GetОrganization.NomerGost = tbGostNumber.Text;
            GetОrganization.NomerGostDate = dtGostDate.Value;
            GetОrganization.RegistrationDate = dtRegistration.Value;        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (btnSave.Text == "Обновлять") return;
            else
            {
                RegistrationUser registration = new RegistrationUser();
                registration.Show();
            }
                
        }

        private void tbBankAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
