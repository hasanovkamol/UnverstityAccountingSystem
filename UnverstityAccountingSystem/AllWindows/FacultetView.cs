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
        public FacultetView()
        {
            InitializeComponent();
            Refresh();
        }
        private List<Data.Facultet> Facultets = new List<Data.Facultet>();
        private void Refresh()
        {
            Facultets = GloblMain.dbo.Facultets.ToList();
            lsEducationalDirection.Items.Add(Facultets.Where(x => x.Name == lsFacultet.SelectedItem.ToString()));
        }
        private void lsFacultet_SelectedValueChanged(object sender, EventArgs e)
        {
            tbFacultet.Text = lsFacultet.SelectedValue.ToString();
            lsEducationalDirection.Items.Clear();
            facultet = Facultets.Where(x => x.Name == tbFacultet.Text).FirstOrDefault();
            lsEducationalDirection.Items.Add(facultet.educationalDirections);
        }

        private void lsEducationalDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbEducationalDirection.Text = lsEducationalDirection.SelectedItem.ToString();
        }

        private void btnFacultet_Click(object sender, EventArgs e)
        {
            if(tbFacultet.Text.Length>0)
            {
                Facultet facultet = new Facultet();
                lsFacultet.Items.Add(tbFacultet.Text);
                facultet.Name = tbFacultet.Text;
                facultet.ApplyChanges();
                Refresh();
            }
        }

        private void btnEducationalDirection_Click(object sender, EventArgs e)
        {
            if (tbEducationalDirection.Text.Length > 0)
            {
                lsEducationalDirection.Items.Add(tbEducationalDirection.Text);         
                facultet.educationalDirections.Add(tbEducationalDirection.Text);
                facultet.ApplyChanges();
                Refresh();

            }

        }
    }
}
