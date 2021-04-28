using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Text;

namespace UnverstityAccountingSystem.Data
{
    [Table("Banks")]
    public class Bank:DataModel
    {
        private string m_Name;
        private string m_Address;
        private string m_MFO;
        private string m_Telefon;
        private int m_BankId;

        [Key]
        public int BankId { get => GetValue(nameof(BankId), m_BankId); set => SetValue(nameof(BankId), ref m_BankId, value); }
        public string Name { get=>GetValue(nameof(Name),m_Name); set=>SetValue(nameof(Name), ref m_Name,value); }
        public string Address { get => GetValue(nameof(Address), m_Address); set => SetValue(nameof(Address), ref m_Address, value); }
        public string MFO { get => GetValue(nameof(MFO), m_MFO); set => SetValue(nameof(MFO), ref m_MFO, value); }
        public string Telefon { get => GetValue(nameof(Telefon), m_Telefon); set => SetValue(nameof(Telefon), ref m_Telefon, value); }

        public override void ApplyChanges()
        {
            GloblMain.dbo.Banks.AddOrUpdate(this);
            base.ApplyChanges();
        }
        public bool NotNullModel()
        {
            if (m_Name.Length>0 && m_Address.Length>0 && m_MFO.Length>0 && m_Telefon.Length>0) return true;
            return  false ;
        }
      
        public Bank FindBank(int id)
        {
            return new Bank() { BankId = 1, Name = "Akfa", Telefon = "997832547", MFO = "123231", Address = "Samarqand" };
        }
    }
}
