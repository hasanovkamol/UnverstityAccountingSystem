using EntityModel.Data;
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
    public partial class AddBank : Form
    {
        Bank bank = new Bank();
        public AddBank(int bankId=0)
        {
            InitializeComponent();
            if (bankId != 0)
            {
                //this.bank = bank;
                BindView();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbError.Text = "";
            BindModel();
            if (bank.NotNullModel())
            {
                bank.ApplyChanges();
                btnSave.Enabled = false;
                btnSave.BackColor = Color.Gray;
                btnSave.Text = "Информация сохранена";
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
    }
}
