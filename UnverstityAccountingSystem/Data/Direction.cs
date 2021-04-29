using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnverstityAccountingSystem.Data
{
    public class Direction:DataModel
    {
        private int m_Id;
        private string m_Name;
        private int m_FacultetId;
        private  Facultet m_facultet;

        public int Id { get=>GetValue(nameof(Id),m_Id); set=>SetValue(nameof(Id), ref m_Id, value); }
        public string Name { get=>GetValue(nameof(Name), m_Name); set=>SetValue(nameof(Name),ref m_Name, value); }
        public int FacultetId { get=>GetValue(nameof(FacultetId),m_FacultetId); set=>SetValue(nameof(FacultetId), ref m_FacultetId, value); }
        public virtual  Facultet facultet { get=>GetValue(nameof(facultet),m_facultet); set=>SetValue(nameof(facultet),ref m_facultet,value); }

        public override void ApplyChanges()
        {
            GloblMain.dbo.Directions.AddOrUpdate(this);
            base.ApplyChanges();
        }
    }
}
