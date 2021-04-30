using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnverstityAccountingSystem.Static;

namespace UnverstityAccountingSystem.Data
{
    [Table("Employees")]
    public class Employee:DataModel
    {
        private int m_EmployeeId;
        private string m_Name;
        private string m_Surname;
        private string m_Middilname;
        private DateTime m_Birthday;
        private string m_Gender;
        private string m_INN;
        private string m_INPS;
        private double m_Rate;
        private double m_Payment;
        private DateTime m_DateofEmployment;
        private int m_PositionId;
        private Position m_Position;
        private string m_Workplace;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get=>GetValue(nameof(EmployeeId), m_EmployeeId); set=>SetValue(nameof(EmployeeId), ref m_EmployeeId,value); }
        public string Name { get => GetValue(nameof(Name), m_Name); set => SetValue(nameof(Name), ref m_Name, value); }
        public string Surname { get => GetValue(nameof(Surname), m_Surname); set => SetValue(nameof(Surname), ref m_Surname, value); }
        public string Middilname { get => GetValue(nameof(Middilname), m_Middilname); set => SetValue(nameof(Middilname), ref m_Middilname, value); }
        public DateTime Birthday { get => GetValue(nameof(Birthday), m_Birthday); set => SetValue(nameof(Birthday), ref m_Birthday, value); }
        public string Gender { get => GetValue(nameof(Gender), m_Gender); set => SetValue(nameof(Gender), ref m_Gender, value); }
        public string INN { get => GetValue(nameof(INN), m_INN); set => SetValue(nameof(INN), ref m_INN, value); }
        public string INPS { get => GetValue(nameof(INPS), m_INPS); set => SetValue(nameof(INPS), ref m_INPS, value); }
        public double Rate { get => GetValue(nameof(Rate), m_Rate); set => SetValue(nameof(Rate), ref m_Rate, value); }
        public double Payment { get => GetValue(nameof(Payment), m_Payment); set => SetValue(nameof(Payment), ref m_Payment, value); }
        public DateTime DateofEmployment { get => GetValue(nameof(DateofEmployment), m_DateofEmployment); set => SetValue(nameof(DateofEmployment), ref m_DateofEmployment, value); }
        public int PositionId { get => GetValue(nameof(PositionId), m_PositionId); set => SetValue(nameof(PositionId), ref m_PositionId, value); }
        public virtual Position Position { get => GetValue(nameof(Position), m_Position); set => SetValue(nameof(Position), ref m_Position, value); }
        public string Workplace { get => GetValue(nameof(Workplace), m_Workplace); set => SetValue(nameof(Workplace), ref m_Workplace, value); }
        public override void ApplyChanges()
        {
            GloblMain.dbo.Employees.AddOrUpdate(this);
            base.ApplyChanges();
        }
        public bool NotNullModel()
        {
            if (m_Name.Length > 0 && m_INN.Length > 0 && m_INPS.Length > 0 && m_Middilname.Length > 0 && m_Surname.Length > 0) return true;
            else return false;
        }
    }
}
