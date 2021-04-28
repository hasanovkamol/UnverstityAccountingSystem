namespace UnverstityAccountingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeModelStudent : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Facultet_FacultetId", "dbo.Facultets");
            DropIndex("dbo.Students", new[] { "Facultet_FacultetId" });
            AddColumn("dbo.Students", "FacultetSt", c => c.String());
            AddColumn("dbo.Students", "EducationalDirectionSt", c => c.String());
            DropColumn("dbo.Students", "Facultet_FacultetId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Facultet_FacultetId", c => c.Int());
            DropColumn("dbo.Students", "EducationalDirectionSt");
            DropColumn("dbo.Students", "FacultetSt");
            CreateIndex("dbo.Students", "Facultet_FacultetId");
            AddForeignKey("dbo.Students", "Facultet_FacultetId", "dbo.Facultets", "FacultetId");
        }
    }
}
