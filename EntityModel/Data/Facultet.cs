using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModel.Data
{
    public class Facultet
    {
        [Key]
        public int FacultetId { get; set; }
        public string Name { get; set; }
        public List<EducationalDirection> educationalDirections { get; set; }
    }
}
