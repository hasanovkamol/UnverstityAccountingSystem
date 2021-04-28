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
    public partial class BankAccount : Form
    {
        public BankAccount()
        {
            InitializeComponent();
            Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditBankAccount addEdit = new AddEditBankAccount();
            addEdit.ShowDialog();
            Refresh();


        }
        private void Refresh()
        {
            dgBankAccount.DataSource = GloblMain.dbo.BankAccounts.ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgBankAccount.SelectedCells[0].FormattedValue.ToString());
            GloblMain.bankaccount = GloblMain.dbo.BankAccounts.Find(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgBankAccount.SelectedCells[0].FormattedValue.ToString());
            GloblMain.dbo.BankAccounts.Remove(GloblMain.dbo.BankAccounts.Find(id));
            GloblMain.dbo.SaveChanges();
            MessageBox.Show("Удалить банковский счет", "Удалить");
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgBankAccount.SelectedCells[0].FormattedValue.ToString());
            var _bankAccount = GloblMain.dbo.BankAccounts.Include("GetBank").ToList();
            AddEditBankAccount addEditBank = new AddEditBankAccount(_bankAccount.Where(x => x.BankAccountId == id).FirstOrDefault());
            addEditBank.ShowDialog();
            Refresh();
        }
    }
}
