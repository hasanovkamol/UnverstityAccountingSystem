using System;
using System.Linq;
using System.Windows.Forms;
using UnverstityAccountingSystem.Data;

namespace UnverstityAccountingSystem.AllWindows
{
    public partial class AddEditBankAccount : Form
    {
        UnverstityAccountingSystem.Data.BankAccount account = new UnverstityAccountingSystem.Data.BankAccount();
        Bank bank = new Bank();
        public AddEditBankAccount(UnverstityAccountingSystem.Data.BankAccount bankAccount=null)
        {
            InitializeComponent();
            if (bankAccount != null)
            {
                this.account = bankAccount;
                BindView();
                btnSave.Text = "Изменить";
            }
            Refresh();
        }

        private void btnValuta_Click(object sender, EventArgs e)
        {
            Valuta valuta = new Valuta();
            valuta.ShowDialog();
            Refresh();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            BankView bank = new BankView();
            bank.ShowDialog();
            account.GetBank = GloblMain.bank;
            if (account.GetBank.Name == null) return;
            else tbGetBank.Text = account.GetBank.Name;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BindModel();
            if (account.NotNullMode())
            {
                account.ApplyChanges();
            }

        }
        private void BindModel()
        {
            account.Name = tbName.Text;
            account.AccountNumber =tbAccountNumber.Text;
            account.Valuta = tbValuta.SelectedItem.ToString();
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
             tbGetBank.Text = account.GetBank.Name;
            tbValuta.SelectedValue =account.Valuta;
             dtContracTerminationDate.Value= account.ContracTerminationDate;
             tbAccountBalance.Text= account.AccountBalance.ToString();
             dtDateofContract.Value= account.DateofContract;
        }

        private void AddEditBankAccount_Load(object sender, EventArgs e)
        {

        }
        private void Refresh()
        {
            tbValuta.Items.Clear();
            foreach(var item in GloblMain.dbo.Valutas.ToList()){
                tbValuta.Items.Add(item.Name);
            }
        }
    }
}
