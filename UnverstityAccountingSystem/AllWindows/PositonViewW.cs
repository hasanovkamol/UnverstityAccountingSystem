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
    public partial class PositonViewW : Form
    {

        Data.Position position = new Data.Position();
        public PositonViewW(Data.Position position = null)
        {
            InitializeComponent();
            if (position != null)
            {
                this.position = position;
                BindVew();
            }
        }

        private void tbBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BindModel();
            if (position.NotNullModel())
            {
                position.ApplyChanges();
            }
            else tbError.Text = "Информация неутомима";
        }
        private void BindModel()
        {
            position.Name = tbPosition.Text;
            position.Decreption = tbDescreption.Text;
        }
        private void BindVew()
        {
            tbPosition.Text = position.Name;
            tbDescreption.Text = position.Decreption;
        }

        private void PositonView_Load(object sender, EventArgs e)
        {

        }
    }
}
