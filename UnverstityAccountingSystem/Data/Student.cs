using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnverstityAccountingSystem.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Course { get; set; }
        public Facultet Facultet { get; set; } 
        public bool PaymentAgreement { get; set; }
        public bool Scholarship { get; set; }
    }
}
