namespace UnverstityAccountingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NeModelEmployeeAndPotio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Middilname = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        INN = c.String(),
                        INPS = c.String(),
                        Rate = c.Double(nullable: false),
                        Payment = c.Double(nullable: false),
                        DateofEmployment = c.DateTime(nullable: false),
                        PositionId = c.Int(nullable: false),
                        Workplace = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Decreption = c.String(),
                    })
                .PrimaryKey(t => t.PositionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "PositionId", "dbo.Positions");
            DropIndex("dbo.Employees", new[] { "PositionId" });
            DropTable("dbo.Positions");
            DropTable("dbo.Employees");
        }
    }
}
