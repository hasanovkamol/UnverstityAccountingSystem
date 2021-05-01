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
    public partial class Report : UserControl
    {
        SalaryListDataGrid salaryListData = new SalaryListDataGrid();
        SalaryEmployeeListDataGrid grid = new SalaryEmployeeListDataGrid();
        public Report()
        {
            InitializeComponent();
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalaryEmployeeView salaryEmployee = new SalaryEmployeeView();
            salaryEmployee.ShowDialog();
            Refresh();

        }
        private void Refresh()
        {
            List<SalaryListDataGrid> salaryListDatas = new List<SalaryListDataGrid>();
            foreach (var item in GloblMain.dbo.Salaries.ToList())
            {
                salaryListData.Id = item.SalaryId;
                salaryListData.Name = item.Name;
                salaryListData.SalaryTimeTo = item.SalaryTimeTo;
                salaryListDatas.Add(salaryListData);
                salaryListData = new SalaryListDataGrid();
            }
            dgSalaryList.DataSource = salaryListDatas;
        }
        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void dgSalaryList_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgSalaryList.SelectedCells[0].FormattedValue.ToString());
            BindHisob(id);

        }
        private void BindHisob(int id)
        {
            double summ = 0;
            List<SalaryEmployeeListDataGrid> listDataGrids = new List<SalaryEmployeeListDataGrid>();
            foreach (var item in GloblMain.dbo.SalaryEmployees.Where(x=>x.SalaryId==id).ToList())
            {
                grid.Id = item.EmployeeId;
                grid.FIO = FindEmployeeFIO(item.EmployeeId);
                summ += FindEmployeePrise(item.EmployeeId, item.ESP);
                grid.Price = FindEmployeePrise(item.EmployeeId, item.ESP).ToString();
                listDataGrids.Add(grid);
                grid = new SalaryEmployeeListDataGrid();
            }
            lbSumma.Text = "Итого: " + summ.ToString()+"Sum";
            dgListEmploee.DataSource = listDataGrids;
        }
        private double FindEmployeePrise(int empId,double esp)
        {
            return GloblMain.dbo.Employees.Find(empId).Payment - esp;
        }
        private string FindEmployeeFIO(int empId)
        {
            var _emp = GloblMain.dbo.Employees.Find(empId);
            return _emp.Name + " " + _emp.Surname + " " + _emp.Middilname;
        }
    }
}
