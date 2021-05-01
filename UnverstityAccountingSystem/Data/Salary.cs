using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;

namespace UnverstityAccountingSystem.Data
{
    [Table("Salaries")]
    public class Salary:DataModel
    {

        private int m_SalaryId;
        private string m_Name;
        private DateTime m_SalaryTimeTo;
        private ICollection<SalaryEmployee> m_salaryEmployees;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalaryId { get => GetValue(nameof(SalaryId), m_SalaryId); set => SetValue(nameof(SalaryId), ref m_SalaryId, value); }
        public string Name { get => GetValue(nameof(Name), m_Name); set => SetValue(nameof(Name), ref m_Name, value); }
        public DateTime SalaryTimeTo { get => GetValue(nameof(SalaryTimeTo), m_SalaryTimeTo); set => SetValue(nameof(SalaryTimeTo), ref m_SalaryTimeTo, value); }
        public ICollection<SalaryEmployee> salaryEmployeesList { get=>GetValue(nameof(salaryEmployeesList),m_salaryEmployees); set=>SetValue(nameof(salaryEmployeesList), ref m_salaryEmployees,value); }
        public override void ApplyChanges()
        {
            GloblMain.dbo.Salaries.AddOrUpdate(this);
            base.ApplyChanges();
        }
        
    }
    public class SalaryListDataGrid
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime SalaryTimeTo { get; set; }
    }
}
