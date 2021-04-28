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
    public partial class Valuta : Form
    {
        UnverstityAccountingSystem.Data.Valuta valuta = new UnverstityAccountingSystem.Data.Valuta();
        public Valuta()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbError.Text = "";
            BindModel();
            if (valuta.NotNullMode())
            {
                lbError.Text = "Информация сохранена";
                valuta.ApplyChanges();      
                // Update datagird sourse
            }
            else lbError.Text = "Вы не ввели данные полностью";
        }
        private void BindModel()
        {
            valuta.ValutaKod = tbKod.Text;
            valuta.Name = tbName.Text;
            valuta.Descreption = tbDescreption.Text;
        }
        private void BindView(UnverstityAccountingSystem.Data.Valuta valuta)
        {
            tbKod.Text = valuta.ValutaKod;
            tbName.Text = valuta.Name;
            tbDescreption.Text = valuta.Descreption;
        }

        

        private void Valuta_Load(object sender, EventArgs e)
        {

        }
       

        private void btnSelect_Click(object sender, EventArgs e)
        {
         
        }
    }
}
