using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Text;

namespace UnverstityAccountingSystem.Data
{
    [Table("Валутас")]
    public class Valuta:DataModel
    {
        private int m_ValutaId;
        private string m_Name;
        private string m_Descreption;
        private string m_ValutaKod;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ValutaId { get=>GetValue(nameof(ValutaId),m_ValutaId); set=>SetValue(nameof(ValutaId), ref m_ValutaId,value); }
        public string ValutaKod { get=>GetValue(nameof(ValutaKod),m_ValutaKod); set=>SetValue(nameof(ValutaKod), ref m_ValutaKod,value); }
        public string Name { get => GetValue(nameof(Name), m_Name); set => SetValue(nameof(Name), ref m_Name, value); }
        public string Descreption { get => GetValue(nameof(Descreption), m_Descreption); set => SetValue(nameof(Descreption), ref m_Descreption, value); }

        public override void ApplyChanges()
        {
            GloblMain.dbo.Valutas.AddOrUpdate(this);
            base.ApplyChanges();
        }
        public bool NotNullMode()
        {
            if (m_Descreption.Length > 0 && m_Name.Length > 0 && m_ValutaKod.Length > 0) return true;
            return false;
        }
    }
}
