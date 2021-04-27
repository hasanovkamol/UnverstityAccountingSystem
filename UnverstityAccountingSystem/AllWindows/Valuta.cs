﻿using System;
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
        EntityModel.Data.Valuta valuta = new EntityModel.Data.Valuta();
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
                btnAdd.Enabled = false;
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
        private void BindView()
        {
            tbKod.Text = valuta.ValutaKod;
            tbName.Text = valuta.Name;
            tbDescreption.Text = valuta.Descreption;
        }

        private void dgValuta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}