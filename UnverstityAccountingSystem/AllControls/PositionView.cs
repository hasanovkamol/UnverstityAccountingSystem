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
    public partial class PositionView : UserControl
    {
        private bool AccountOrPosition = true;
        public PositionView()
        {
            InitializeComponent();
            Refresh();
            lbUser.ForeColor = Color.Green;
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            if (AccountOrPosition)
            {
                UserRegistration user = new UserRegistration();
                user.ShowDialog();
            }
            else
            {
                PositonViewW positonView = new PositonViewW();
                positonView.ShowDialog();
            }
           
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (AccountOrPosition)
            {
                int id = int.Parse(dgUserAccount.SelectedCells[0].FormattedValue.ToString());
                var _account = GloblMain.dbo.Users.Find(id);
                if (_account == null) return;
                else
                {
                    UserRegistration user = new UserRegistration(_account);
                    user.ShowDialog();
                }
            }
            else
            {
                int id = int.Parse(dgPositons.SelectedCells[0].FormattedValue.ToString());
                var _position = GloblMain.dbo.Positions.Find(id);
                if (_position == null) return;
                else
                {
                    PositonViewW positonView = new PositonViewW(_position);
                    positonView.ShowDialog();
                }
            }
            Refresh();
        }
        private void Refresh()
        {
            dgPositons.DataSource = GloblMain.dbo.Positions.ToList();
            dgUserAccount.DataSource = GloblMain.dbo.Users.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (AccountOrPosition)
            {
                int id = int.Parse(dgUserAccount.SelectedCells[0].FormattedValue.ToString());
                var _account = GloblMain.dbo.Users.Find(id);
                if (_account == null) return;
                else
                {
                    GloblMain.dbo.Users.Remove(_account);
                    GloblMain.dbo.SaveChanges();
                    MessageBox.Show("Удаляет данные ");
                }
            }
            else
            {
                int id = int.Parse(dgPositons.SelectedCells[0].FormattedValue.ToString());
                var _position = GloblMain.dbo.Positions.Find(id);
                if (_position == null) return;
                else
                {
                    GloblMain.dbo.Positions.Remove(_position);
                    GloblMain.dbo.SaveChanges();
                    MessageBox.Show("Удаляет данные ");
                }
            }
            Refresh();
        }

        private void PositionView_Load(object sender, EventArgs e)
        {

        }

        private void dgUserAccount_Click(object sender, EventArgs e)
        {
            lbUser.ForeColor = Color.Green;
            lbPosition.ForeColor = Color.Black;
            AccountOrPosition = true;
        }

        private void dgPositons_Click(object sender, EventArgs e)
        {
            lbPosition.ForeColor = Color.Green;
            lbUser.ForeColor = Color.Black;
            AccountOrPosition = false; 
        }
    }
}
