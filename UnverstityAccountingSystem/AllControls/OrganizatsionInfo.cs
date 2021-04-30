using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnverstityAccountingSystem.AllWindows;
using UnverstityAccountingSystem.Data;

namespace UnverstityAccountingSystem.AllControls
{
    public partial class OrganizatsionInfo : UserControl
    {
        Оrganization оrganization = new Оrganization();
        public OrganizatsionInfo(Оrganization  оrganization=null)
        {
            InitializeComponent();
            if (оrganization != null)
            {
                this.оrganization = оrganization;
                BindView();
            }
        }
        private void BindView()
        {
            lbAddress.Text += ": " + оrganization.Address;
            lbINN.Text += ": " + оrganization.INN;
            lbAccountNumber.Text += ": " + оrganization.BankAccount.AccountNumber;
            lbBalans.Text += ": " + оrganization.BankAccount.AccountBalance;
            lbContracTerminationDate.Text += ": "+оrganization.BankAccount.ContracTerminationDate.ToString();
            lbDateofContract.Text+=": "+ оrganization.BankAccount.DateofContract.ToString();
            lbName.Text += ": " + оrganization.Name;
            lbRegistrationDate.Text += ": " + оrganization.RegistrationDate.ToString();
            lbTelefon.Text += ": " + оrganization.Telefon;
            lbOBankSchot.Text += " "+оrganization.BankAccount.Name;
        }
        private void OrganizatsionInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            РегистрацияОрганизации reg = new РегистрацияОрганизации(оrganization);
            reg.ShowDialog();
            if(DialogResult.OK==reg.DialogResult)
            {
                MessageBox.Show("Информация об организации изменилась. Перезапустите приложение. ");
            }
        }
    }
}
