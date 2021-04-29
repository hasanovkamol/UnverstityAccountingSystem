namespace UnverstityAccountingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassForModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FacultetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facultets", t => t.FacultetId, cascadeDelete: true)
                .Index(t => t.FacultetId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Directions", "FacultetId", "dbo.Facultets");
            DropIndex("dbo.Directions", new[] { "FacultetId" });
            DropTable("dbo.Directions");
        }
    }
}
