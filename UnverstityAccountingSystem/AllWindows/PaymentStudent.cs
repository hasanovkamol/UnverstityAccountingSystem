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
    public partial class PaymentStudent : Form
    {
        StudentDM StudentDM = new StudentDM();
        decimal pirse = 0;
        public PaymentStudent(StudentDM student)
        {
            if (student == null)
            {
                MessageBox.Show("Информация о студенте не найдена "); ;
            }
            else
            {
                InitializeComponent();
                this.StudentDM = student;
                BindView();
                tbValuta.Items.Clear();
                foreach (var item in GloblMain.dbo.Valutas.ToList())
                {
                    tbValuta.Items.Add(item.Name);
                }
            }
            
        }
        private void BindView()
        {
            tbFIO.Text += ": " + StudentDM.Name + " " + StudentDM.Surname;
            tbCourse.Text += ": " + StudentDM.Course;
            tbDiraction.Text += ": " + StudentDM.EducationalDirectionSt;
            tbFacultet.Text += ": " + StudentDM.FacultetSt;
            tbPayment.Text += ": " + StudentDM.ContractMoney;
            pirse = decimal.Parse(StudentDM.ContractMoney.ToString());
        }
        private void BindModel()
        {
            StudentDM.Payment = true;
            StudentDM.ContractMoney =pirse+decimal.Parse(tbPrace.Text);
            GloblMain.SetSumOrg(StudentDM.ContractMoney);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PaymentStudent_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.ShowDialog();
            tbBankAccount.Text = GloblMain.bankaccount.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BindModel();
            if (StudentDM.NotNullModel())
            {
                StudentDM.ApplyChanges();
                MessageBox.Show("Деньги переведены с основного счета ");
            }
            else lbError.Text = "Платеж не прошел ";
        }
    }
}
