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
    [Table("Positions")]
    public class Position:DataModel
    {
        private int m_PositionId;
        private string m_Name;
        private string m_Decreption;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PositionId { get=>GetValue(nameof(PositionId),m_PositionId); set=>SetValue(nameof(PositionId), ref m_PositionId, value); }
        public string Name { get => GetValue(nameof(Name), m_Name); set => SetValue(nameof(Name), ref m_Name, value); }
        public string Decreption { get => GetValue(nameof(Decreption), m_Decreption); set => SetValue(nameof(Decreption), ref m_Decreption, value); }

        public override void ApplyChanges()
        {
            GloblMain.dbo.Positions.AddOrUpdate(this);
            base.ApplyChanges();
        }
        public bool NotNullModel()
        {
            if (m_Name.Length > 0 && m_Decreption.Length > 0)
            {
                if (GloblMain.dbo.Positions.ToList().Where(x => x.Name == m_Name).ToList().Count > 0) return false;
                else return true;
            } 

            else return false;
        }
    }
}
