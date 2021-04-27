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
    public partial class AddEditBankAccount : Form
    {
        EntityModel.Data.BankAccount account = new EntityModel.Data.BankAccount();
        EntityModel.Data.Bank bank = new EntityModel.Data.Bank();
        public AddEditBankAccount()
        {
            InitializeComponent();
        }

        private void btnValuta_Click(object sender, EventArgs e)
        {
            Valuta valuta = new Valuta();
            valuta.ShowDialog();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            BankView bank = new BankView();
            bank.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void BindModel()
        {
            account.Name = tbName.Text;
            account.AccountNumber =tbAccountNumber.Text;
            account.Valuta = tbValuta.SelectedItem.ToString();
            account.GetBank = bank;
            account.ContracTerminationDate = dtContracTerminationDate.Value;
            account.AccountBalance =decimal.Parse(tbAccountBalance.Text);
            account.DateofContract = dtDateofContract.Value;
        }
        private void BindView()
        {
             tbName.Text=account.Name;
             tbAccountNumber.Text= account.AccountNumber;
             tbValuta.SelectedItem= account.Valuta;
             bank= account.GetBank;
             dtContracTerminationDate.Value= account.ContracTerminationDate;
             tbAccountBalance.Text= account.AccountBalance.ToString();
             dtDateofContract.Value= account.DateofContract;
        }
    }
}
