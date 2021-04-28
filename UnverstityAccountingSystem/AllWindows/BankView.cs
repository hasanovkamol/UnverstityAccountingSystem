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
    public partial class BankView : Form
    {
        public BankView()
        {
            InitializeComponent();
            Refresh();
        }
        private void Refresh()
        {
            dgBank.DataSource = GloblMain.dbo.Banks.ToList();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgBank.SelectedCells[0].FormattedValue.ToString());
            GloblMain.bank = GloblMain.dbo.Banks.Find(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBank addBank = new AddBank();
            addBank.ShowDialog();
            Refresh();
        }
       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgBank.SelectedCells[0].FormattedValue.ToString());
            var _bank = GloblMain.dbo.Banks.Find(id);
            AddBank addBank = new AddBank(_bank);
            addBank.ShowDialog();
            Refresh();
        }

        private void BankView_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
