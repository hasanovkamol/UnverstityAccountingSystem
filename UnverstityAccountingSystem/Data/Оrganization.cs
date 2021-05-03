using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Text;

namespace UnverstityAccountingSystem.Data
{
    [Table("Организации")]
    public class Оrganization:DataModel
    {
        private int m_OrganizationId;
        private string m_Name;
        private string m_INN;
        private string m_Address;
        private string m_Telefon;
        private string m_NomerGost;
        private DateTime m_NomerGostDate;
        private DateTime m_RegistrationDate;
        private BankAccount m_BankAccount;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrganizationId { get=>GetValue(nameof(OrganizationId),m_OrganizationId); set=>SetValue(nameof(OrganizationId),ref m_OrganizationId, value); }
        public string Name { get=>GetValue(nameof(Name),m_Name); set=>SetValue(nameof(Name), ref m_Name, value); }
        public string INN { get=>GetValue(nameof(INN), m_INN); set=>SetValue(nameof(INN), ref m_INN, value); }
        public string Address { get=>GetValue(nameof(Address), m_Address); set=>SetValue(nameof(Address), ref m_Address,value); }
        public string  Telefon { get=>GetValue(nameof(Telefon), m_Telefon); set=>SetValue(nameof(Telefon), ref m_Telefon, value); }
        public string  NomerGost { get => GetValue(nameof(NomerGost), m_NomerGost); set => SetValue(nameof(NomerGost), ref m_NomerGost, value); }
        public DateTime  NomerGostDate { get => GetValue(nameof(NomerGostDate), m_NomerGostDate); set => SetValue(nameof(NomerGostDate), ref m_NomerGostDate, value); }
        public DateTime  RegistrationDate { get => GetValue(nameof(RegistrationDate), m_RegistrationDate); set => SetValue(nameof(RegistrationDate), ref m_RegistrationDate, value); }
        public BankAccount BankAccount { get => GetValue(nameof(BankAccount), m_BankAccount); set => SetValue(nameof(BankAccount), ref m_BankAccount, value); }

        public override void ApplyChanges()
        {
            GloblMain.dbo.GetОrganizations.AddOrUpdate(this);
            base.ApplyChanges();
        }
        public bool NotNullModel()
        {
            if (m_BankAccount.Name.Length>0 && m_Name.Length > 0 && m_INN.Length > 0 && m_NomerGost.Length > 0 && m_Address.Length > 0 && m_Telefon.Length > 0) return true;
            else return false;
        }
    }
}
