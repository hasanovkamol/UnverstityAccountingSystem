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
    public partial class FacultetView : Form
    {
        Data.Facultet facultet = new Data.Facultet();
        private int id;
        public FacultetView()
        {
            InitializeComponent();
            Refresh();
            timer1.Start();
        }
        private List<Data.Facultet> Facultets = new List<Data.Facultet>();
        private void Refresh()
        {
            dgFacultet.DataSource= GloblMain.dbo.Facultets.ToList();
        }
        private void RefreshSelect()
        {
            if (GloblMain.dbo.Facultets.Count() == 0) return;
            else
            {
                id = int.Parse(dgFacultet.SelectedCells[0].FormattedValue.ToString());
                tbFacultet.Text = dgFacultet.SelectedCells[1].FormattedValue.ToString();
                dgDirection.DataSource = GloblMain.dbo.Directions.ToList().Where(x => x.FacultetId == id).ToList(); ;
            }
        }

        private void btnFacultet_Click(object sender, EventArgs e)
        {
            if (FindStringDatabase(tbFacultet.Text))
            {
                Facultet facultet = new Facultet();
                facultet.Name = tbFacultet.Text;
                facultet.ApplyChanges();
                dgFacultet.DataSource = GloblMain.dbo.Facultets.ToList();
            }
            else tbError.Text = "Попытка не удалась ";
        }
        private bool FindStringDatabase(string value)
        {
            var xx=GloblMain.dbo.Facultets.ToList().Where(x=>x.Name==value).ToList().FirstOrDefault();
            return xx == null ? true : false;
        }

        private void btnEducationalDirection_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgFacultet.SelectedCells[0].FormattedValue.ToString());
            if (FindStringDatabase(tbEducationalDirection.Text,id))
            {
                Direction direction = new Direction();
                direction.FacultetId = id;
                direction.Name = tbEducationalDirection.Text;
                direction.ApplyChanges();
                dgDirection.DataSource = GloblMain.dbo.Directions.ToList().Where(x=>x.FacultetId==id).ToList();

            }
            else tbError.Text = "Попытка не удалась ";

        }
        private bool FindStringDatabase(string value,int id)
        {
            var xx = GloblMain.dbo.Directions.ToList().Where(x => x.Name == value && x.FacultetId==id).ToList().FirstOrDefault();
            return xx == null ? true : false;
        }

        private void FacultetView_Load(object sender, EventArgs e)
        {

        }

        private void dgFacultet_Click(object sender, EventArgs e)
        {
            RefreshSelect();
        }

        private void dgDirection_Click(object sender, EventArgs e)
        {
            if (GloblMain.dbo.Directions.Count() == 0) return;
            else
            {
                tbEducationalDirection.Text = dgDirection.SelectedCells[1].FormattedValue.ToString();
            }
        }

        private void tbFacultetDelete_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgFacultet.SelectedCells[0].FormattedValue.ToString());
            if(id>0)
            {
                var facultet = GloblMain.dbo.Facultets.Find(id);
                if (facultet == null) return;
                else GloblMain.dbo.Facultets.Remove(facultet);
                
            }
            GloblMain.dbo.SaveChanges();
            Refresh();
        }

        private void btDirectionDelete_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgDirection.SelectedCells[0].FormattedValue.ToString());
            if (id > 0)
            {
                var direction = GloblMain.dbo.Directions.Find(id);
                if (direction == null) return;
                else GloblMain.dbo.Directions.Remove(direction);

            }
            GloblMain.dbo.SaveChanges();
            RefreshSelect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbError.Text = "";
        }
    }
}
