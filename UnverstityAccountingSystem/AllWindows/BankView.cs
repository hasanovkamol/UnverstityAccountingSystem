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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBank addBank = new AddBank();
            addBank.ShowDialog();
        }
        private void FindDatabaseId()
        {
            if (dgBank.SelectedCells==null) return;
            else
                GloblMain.CurrentId =
                    int.Parse(dgBank.SelectedCells[0].FormattedValue.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FindDatabaseId();
            AddBank addBank = new AddBank(GloblMain.CurrentId);
            addBank.ShowDialog();
        }

        private void BankView_Load(object sender, EventArgs e)
        {

        }
    }
}
