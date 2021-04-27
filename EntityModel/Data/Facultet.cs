using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModel.Data
{
    public class Facultet
    {
        public int FacultetId { get; set; }
        public string Name { get; set; }
        public List<EducationalDirection> educationalDirections { get; set; }
    }
}
