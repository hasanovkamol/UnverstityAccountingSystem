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
    public partial class EmployeeAddOrUpdateView : Form
    {
        Employee employee = new Employee();
        public EmployeeAddOrUpdateView(Employee employee=null)
        {
            InitializeComponent(); Refresh();
            if (employee != null)
            {
                this.employee = employee;
                BindView();
            }
        }
        private void Refresh()
        {
            foreach (var item in GloblMain.dbo.Positions.ToList())
            {
               cobPosition.Items.Add(item.Name);
            }
        }
        private void EmployeeAddOrUpdateView_Load(object sender, EventArgs e)
        {

        }
        private void BindModel()
        {
            employee.Name = tbName.Text;
            employee.Surname = tbSurname.Text;
            employee.Middilname = tbMidilname.Text;
            employee.Gender = cobGender.SelectedItem.ToString();
            employee.Birthday = dtBirthday.Value;
            employee.INN = tbINN.Text;
            employee.INPS = tbINPS.Text;
            employee.Payment = double.Parse(tbPayment.Text);
            employee.Rate = double.Parse(tbRate.Text);
            employee.DateofEmployment = dtDateOfWorking.Value;
            employee.PositionId =FindPosition(cobPosition.SelectedItem.ToString());
        }
        private void BindView()
        {
              tbName.Text= employee.Name;
              tbSurname.Text= employee.Surname;
             tbMidilname.Text= employee.Middilname;
              cobGender.SelectedItem= employee.Gender;
             dtBirthday.Value= employee.Birthday;
             tbINN.Text= employee.INN;
             tbINPS.Text= employee.INPS;
            tbPayment.Text = employee.Payment.ToString();
            tbRate.Text = employee.Rate.ToString();
             dtDateOfWorking.Value= employee.DateofEmployment;
             cobPosition.SelectedItem= FindPosition(employee.PositionId);
        }
        private string FindPosition(int id)
        {
            return GloblMain.dbo.Positions.Find(id).Name;
        }
        private int FindPosition(string name)
        {
            return GloblMain.dbo.Positions.ToList().Where(x=>x.Name==name).FirstOrDefault().PositionId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BindModel();
            if (employee.NotNullModel())
            {
                employee.ApplyChanges();
            }
            else tbError.Text = "Данные неполные ";
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            PositonViewW positonView = new PositonViewW();
            positonView.ShowDialog();
            Refresh();
        }
    }
}
