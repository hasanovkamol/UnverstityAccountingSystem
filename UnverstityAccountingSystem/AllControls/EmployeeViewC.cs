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

namespace UnverstityAccountingSystem.AllControls
{
    public partial class EmployeeViewC : UserControl
    {
        public EmployeeViewC()
        {
            InitializeComponent();
            Refresh();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            EmployeeAddOrUpdateView employee = new EmployeeAddOrUpdateView();
            employee.ShowDialog();
            Refresh();
        }
        private void Refresh()
        {
            dgEmployee.DataSource = GloblMain.dbo.Employees.ToList();
        }
        private void EmployeeViewC_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgEmployee.SelectedCells[0].FormattedValue.ToString());
            var _employee = GloblMain.dbo.Employees.Find(id);
            if (_employee == null) return;
            else
            {
                EmployeeAddOrUpdateView employee = new EmployeeAddOrUpdateView(_employee);
                employee.ShowDialog();
                Refresh();
            }
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgEmployee.SelectedCells[0].FormattedValue.ToString());
            var _employee = GloblMain.dbo.Employees.Find(id);
            if (_employee == null) return;
            else
            {
                GloblMain.dbo.Employees.Remove(_employee);
                GloblMain.dbo.SaveChanges();
                Refresh();
            }
        }
    }
}
