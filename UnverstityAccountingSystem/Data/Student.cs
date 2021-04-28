using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Text;

namespace UnverstityAccountingSystem.Data
{
    [Table("Students")]
    public class Student:DataModel
    {
        private int m_StudentId;
        private string m_Name;
        private string m_Surname;
        private string m_FacultetSt;
        private string m_EducationalDirectionSt;
        private bool m_PaymentAgreement;
        private bool m_Scholarship;

        [Key]
        public int StudentId { get=>GetValue(nameof(StudentId),m_StudentId); set=>SetValue(nameof(StudentId), ref m_StudentId,value); }
        public string Name { get => GetValue(nameof(Name), m_Name); set => SetValue(nameof(Name), ref m_Name, value); }
        public string Surname { get => GetValue(nameof(Surname), m_Surname); set => SetValue(nameof(Surname), ref m_Surname, value); }
        public int Course { get => GetValue(nameof(StudentId), m_StudentId); set => SetValue(nameof(StudentId), ref m_StudentId, value); }
        public string FacultetSt { get => GetValue(nameof(FacultetSt), m_FacultetSt); set => SetValue(nameof(FacultetSt), ref m_FacultetSt, value); }
        public string EducationalDirectionSt { get => GetValue(nameof(EducationalDirectionSt), m_EducationalDirectionSt); set => SetValue(nameof(EducationalDirectionSt), ref m_EducationalDirectionSt, value); }
        public bool PaymentAgreement { get => GetValue(nameof(PaymentAgreement), m_PaymentAgreement); set => SetValue(nameof(PaymentAgreement), ref m_PaymentAgreement, value); }
        public bool Scholarship { get => GetValue(nameof(Scholarship), m_Scholarship); set => SetValue(nameof(Scholarship), ref m_Scholarship, value); }

        public override void ApplyChanges()
        {
            GloblMain.dbo.Students.AddOrUpdate(this);
            base.ApplyChanges();
        }
        public bool NotNullModel()
        {
            if (m_Name.Length > 0 && m_FacultetSt.Length > 0 && m_Surname.Length > 0 && m_EducationalDirectionSt.Length > 0) return true;
            else return false;
        }
    }
}
