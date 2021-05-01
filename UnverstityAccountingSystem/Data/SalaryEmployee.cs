using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnverstityAccountingSystem.Data
{
    [Table("SalaryEmployees")]
    public class SalaryEmployee:DataModel
    {
        private int m_SalaryEmployeeId;
        private int m_EmployeeId;
        private double m_INNPS;
        private double m_ENDF;
        private double m_ESP;
        private Salary m_salaries;
        private int m_SalaryId;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalaryEmployeeId { get=>GetValue(nameof(SalaryEmployeeId), m_SalaryEmployeeId); set=>SetValue(nameof(SalaryEmployeeId),ref m_SalaryEmployeeId, value); }
        public int EmployeeId { get=>GetValue(nameof(EmployeeId), m_EmployeeId); set=>SetValue(nameof(EmployeeId),ref m_EmployeeId, value); }
        public double INNPS { get => GetValue(nameof(INNPS), m_INNPS); set => SetValue(nameof(INNPS), ref m_INNPS, value); }
        public double ENDF { get => GetValue(nameof(ENDF), m_ENDF); set => SetValue(nameof(ENDF), ref m_ENDF, value); }
        public double ESP { get => GetValue(nameof(ESP), m_ESP); set => SetValue(nameof(ESP), ref m_ESP, value); }
 
        public int SalaryId { get=>GetValue(nameof(SalaryId), m_SalaryId); set=>SetValue(nameof(SalaryId),ref m_SalaryId,value); }
        public virtual Salary SalariesList { get=>GetValue(nameof(SalariesList), m_salaries); set=>SetValue(nameof(SalariesList),ref m_salaries,value); }
        public override void ApplyChanges()
        {
            GloblMain.dbo.SalaryEmployees.AddOrUpdate(this);
            base.ApplyChanges();
        }
    }
    public class SalaryEmployeeListDataGrid
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Price { get; set; }
    }
    
}
