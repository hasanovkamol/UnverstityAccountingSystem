using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModel.Data
{
    public class EducationalDirection
    {
        [Key]
        public int EDId { get; set; }
        public string EDName { get; set; }
        public string EDDescreption { get; set; }
    }
}
