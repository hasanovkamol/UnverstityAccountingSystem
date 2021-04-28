namespace UnverstityAccountingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        BankAccountId = c.Int(nullable: false, identity: true),
                        Valuta = c.String(),
                        AccountNumber = c.String(),
                        Name = c.String(),
                        DateofContract = c.DateTime(nullable: false),
                        ContracTerminationDate = c.DateTime(nullable: false),
                        AccountBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GetBank_BankId = c.Int(),
                    })
                .PrimaryKey(t => t.BankAccountId)
                .ForeignKey("dbo.Banks", t => t.GetBank_BankId)
                .Index(t => t.GetBank_BankId);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        BankId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        MFO = c.String(),
                        Telefon = c.String(),
                    })
                .PrimaryKey(t => t.BankId);
            
            CreateTable(
                "dbo.EducationalDirections",
                c => new
                    {
                        EDId = c.Int(nullable: false, identity: true),
                        EDName = c.String(),
                        EDDescreption = c.String(),
                        Facultet_FacultetId = c.Int(),
                    })
                .PrimaryKey(t => t.EDId)
                .ForeignKey("dbo.Facultets", t => t.Facultet_FacultetId)
                .Index(t => t.Facultet_FacultetId);
            
            CreateTable(
                "dbo.Facultets",
                c => new
                    {
                        FacultetId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.FacultetId);
            
            CreateTable(
                "dbo.Оrganization",
                c => new
                    {
                        OrganizationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        INN = c.String(),
                        Address = c.String(),
                        Telefon = c.String(),
                        NomerGost = c.String(),
                        NomerGostDate = c.DateTime(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        BankAccount_BankAccountId = c.Int(),
                    })
                .PrimaryKey(t => t.OrganizationId)
                .ForeignKey("dbo.BankAccounts", t => t.BankAccount_BankAccountId)
                .Index(t => t.BankAccount_BankAccountId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Course = c.Int(nullable: false),
                        PaymentAgreement = c.Boolean(nullable: false),
                        Scholarship = c.Boolean(nullable: false),
                        Facultet_FacultetId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Facultets", t => t.Facultet_FacultetId)
                .Index(t => t.Facultet_FacultetId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserRoll = c.Int(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Valutas",
                c => new
                    {
                        ValutaId = c.Int(nullable: false, identity: true),
                        ValutaKod = c.String(),
                        Name = c.String(),
                        Descreption = c.String(),
                    })
                .PrimaryKey(t => t.ValutaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Facultet_FacultetId", "dbo.Facultets");
            DropForeignKey("dbo.Оrganization", "BankAccount_BankAccountId", "dbo.BankAccounts");
            DropForeignKey("dbo.EducationalDirections", "Facultet_FacultetId", "dbo.Facultets");
            DropForeignKey("dbo.BankAccounts", "GetBank_BankId", "dbo.Banks");
            DropIndex("dbo.Students", new[] { "Facultet_FacultetId" });
            DropIndex("dbo.Оrganization", new[] { "BankAccount_BankAccountId" });
            DropIndex("dbo.EducationalDirections", new[] { "Facultet_FacultetId" });
            DropIndex("dbo.BankAccounts", new[] { "GetBank_BankId" });
            DropTable("dbo.Valutas");
            DropTable("dbo.Users");
            DropTable("dbo.Students");
            DropTable("dbo.Оrganization");
            DropTable("dbo.Facultets");
            DropTable("dbo.EducationalDirections");
            DropTable("dbo.Banks");
            DropTable("dbo.BankAccounts");
        }
    }
}
