namespace UnverstityAccountingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changmodelFacultet : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EducationalDirections", "Facultet_FacultetId", "dbo.Facultets");
            DropIndex("dbo.EducationalDirections", new[] { "Facultet_FacultetId" });
            DropTable("dbo.EducationalDirections");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EducationalDirections",
                c => new
                    {
                        EDId = c.Int(nullable: false, identity: true),
                        EDName = c.String(),
                        EDDescreption = c.String(),
                        Facultet_FacultetId = c.Int(),
                    })
                .PrimaryKey(t => t.EDId);
            
            CreateIndex("dbo.EducationalDirections", "Facultet_FacultetId");
            AddForeignKey("dbo.EducationalDirections", "Facultet_FacultetId", "dbo.Facultets", "FacultetId");
        }
    }
}
