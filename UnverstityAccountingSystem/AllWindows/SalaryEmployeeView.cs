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
    public partial class SalaryEmployeeView : Form
    {
        Salary salary = new Salary();
        SalaryEmployee salaryEmployee = new SalaryEmployee();
        public SalaryEmployeeView()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private void BindModel()
        {
            salary.Name = tbName.Text;
            salary.SalaryTimeTo = dtMonth.Value;
        }
        private void HisobEmployee(int SalaryId)
        {
            decimal summ = 0;
            foreach (var item in GloblMain.dbo.Employees.ToList())
            {
                salaryEmployee.SalaryId = SalaryId;
                salaryEmployee.EmployeeId = item.EmployeeId;
                salaryEmployee.INNPS = item.Payment * 0.001;
                salaryEmployee.ENDF = item.Payment * 0.12- salaryEmployee.INNPS;
                salaryEmployee.ESP= item.Payment * 0.12;
                summ +=decimal.Parse(item.Payment.ToString());
                salaryEmployee.ApplyChanges();
                salaryEmployee = new SalaryEmployee();
            }
            dgSalary.DataSource = GloblMain.dbo.SalaryEmployees.ToList()
                .Where(x=>x.SalaryId==SalaryId).ToList();
            if (GloblMain.GetSumOrg(summ)) MessageBox.Show("Оплачивается ежемесячно с основного счета ");
            else MessageBox.Show("На основном счете недостаточно денег ");          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindModel();
            if (salary.Name.Length > 0)
            {
                salary.ApplyChanges();
                int _salaryId = GloblMain.dbo.Salaries.ToList().LastOrDefault().SalaryId;
                HisobEmployee(_salaryId);
            }
            else tbError.Text = "Информация неполная ";
        }
    }
}
