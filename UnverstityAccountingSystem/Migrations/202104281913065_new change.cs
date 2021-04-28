namespace UnverstityAccountingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newchange : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Оrganization", newName: "Оrganizations");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Оrganizations", newName: "Оrganization");
        }
    }
}
