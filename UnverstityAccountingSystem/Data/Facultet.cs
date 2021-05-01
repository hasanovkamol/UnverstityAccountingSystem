using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Text;

namespace UnverstityAccountingSystem.Data
{
    [Table("Facultets")]
    public class Facultet:DataModel
    {
        private int m_FacultetId;
        private string m_Name;
        private ICollection<Direction> m_FacultetDirections;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FacultetId { get=>GetValue(nameof(FacultetId),m_FacultetId); set=>SetValue(nameof(Facultet), ref m_FacultetId, value); }
        public string Name { get => GetValue(nameof(Name), m_Name); set => SetValue(nameof(Name), ref m_Name, value); }  
        public ICollection<Direction> FacultetDirections { get=>GetValue(nameof(FacultetDirections), m_FacultetDirections); set=>SetValue(nameof(FacultetDirections),ref m_FacultetDirections, value); }
        public override void ApplyChanges()
        {
            GloblMain.dbo.Facultets.AddOrUpdate(this);
            base.ApplyChanges();
        }
    }
}
