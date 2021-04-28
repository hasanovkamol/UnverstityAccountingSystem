
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
    public partial class AddBank : Form
    {
        Bank bank = new Bank();
        public AddBank(Bank bank=null)
        {
            InitializeComponent();
            if (bank != null)
            {
                this.bank = bank;
                BindView();
                btnSave.Text = "Изменить";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbError.Text = "";
            BindModel();
            if (bank.NotNullModel())
            {
                bank.ApplyChanges();
            }
            else tbError.Text = "Вы не ввели данные полностью ";
        }
        private void BindModel()
        {
            bank.Name = tbName.Text;
            bank.Telefon = tbTelefon.Text;
            bank.Address = tbAddress.Text;
            bank.MFO = tbMFO.Text;
        }
        private void BindView()
        {
            tbName.Text = bank.Name;
            tbAddress.Text = bank.Address;
            tbMFO.Text = bank.MFO;
            tbTelefon.Text = bank.Telefon;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
