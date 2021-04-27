using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModel.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Course { get; set; }
        public Facultet Facultet { get; set; } 
        public bool PaymentAgreement { get; set; }
        public bool Scholarship { get; set; }
    }
}
