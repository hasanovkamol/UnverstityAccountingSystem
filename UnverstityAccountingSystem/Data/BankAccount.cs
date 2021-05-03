using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Text;

namespace UnverstityAccountingSystem.Data
{
    [Table("Банксчета")]
    public class BankAccount:DataModel
    {
        private int m_BankAccountId;
        private string m_Valuta;
        private string m_AccountNumber;
        private string m_Name;
        private decimal m_AccountBalance;
        private DateTime m_ContracTerminationDate;
        private DateTime m_DateofContract;
        private Bank m_GetBook;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BankAccountId { get=>GetValue(nameof(BankAccountId),m_BankAccountId); set=>SetValue(nameof(BankAccountId),ref m_BankAccountId,value); }
        public string Valuta { get => GetValue(nameof(Valuta), m_Valuta); set => SetValue(nameof(Valuta), ref m_Valuta, value); }
        public string AccountNumber { get => GetValue(nameof(AccountNumber), m_AccountNumber); set => SetValue(nameof(AccountNumber), ref m_AccountNumber, value); }
        public string Name { get => GetValue(nameof(Name), m_Name); set => SetValue(nameof(Name), ref m_Name, value); }
        public DateTime DateofContract { get=>GetValue(nameof(DateofContract),m_DateofContract); set=>SetValue(nameof(DateofContract),ref m_DateofContract,value); }
        public DateTime ContracTerminationDate { get=>GetValue(nameof(ContracTerminationDate),m_ContracTerminationDate); set=>SetValue(nameof(ContracTerminationDate),ref m_ContracTerminationDate,value); }
        public decimal AccountBalance { get => GetValue(nameof(AccountBalance), m_AccountBalance); set => SetValue(nameof(AccountBalance), ref m_AccountBalance, value); }
        public Bank GetBank { get=>GetValue(nameof(GetBank), m_GetBook); set=>SetValue(nameof(GetBank),ref m_GetBook,value); }
        public override void ApplyChanges()
        {
            GloblMain.dbo.BankAccounts.AddOrUpdate(this);
            base.ApplyChanges();
        }
        public bool NotNullMode()
        {
            if (m_Valuta.Length > 0 && m_Name.Length > 0 && m_AccountBalance > 0 && m_AccountNumber.Length > 0) return true;
            return false; 
        }
    }
}
