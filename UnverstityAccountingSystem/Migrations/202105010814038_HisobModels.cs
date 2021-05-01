namespace UnverstityAccountingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HisobModels : DbMigration
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
            
            CreateTable(
                "dbo.Facultets",
                c => new
                    {
                        FacultetId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.FacultetId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Middilname = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Gender = c.String(),
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
            
            CreateTable(
                "dbo.Оrganizations",
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
                "dbo.Salaries",
                c => new
                    {
                        SalaryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SalaryTimeTo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SalaryId);
            
            CreateTable(
                "dbo.SalaryEmployees",
                c => new
                    {
                        SalaryEmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        INNPS = c.Double(nullable: false),
                        ENDF = c.Double(nullable: false),
                        ESP = c.Double(nullable: false),
                        SalaryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SalaryEmployeeId)
                .ForeignKey("dbo.Salaries", t => t.SalaryId, cascadeDelete: true)
                .Index(t => t.SalaryId);
            
            CreateTable(
                "dbo.StudentDMs",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Course = c.Int(nullable: false),
                        FacultetSt = c.String(),
                        EducationalDirectionSt = c.String(),
                        PaymentAgreement = c.Boolean(nullable: false),
                        Scholarship = c.Boolean(nullable: false),
                        Payment = c.Boolean(nullable: false),
                        ContractMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StudentId);
            
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
            DropForeignKey("dbo.SalaryEmployees", "SalaryId", "dbo.Salaries");
            DropForeignKey("dbo.Оrganizations", "BankAccount_BankAccountId", "dbo.BankAccounts");
            DropForeignKey("dbo.Employees", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Directions", "FacultetId", "dbo.Facultets");
            DropForeignKey("dbo.BankAccounts", "GetBank_BankId", "dbo.Banks");
            DropIndex("dbo.SalaryEmployees", new[] { "SalaryId" });
            DropIndex("dbo.Оrganizations", new[] { "BankAccount_BankAccountId" });
            DropIndex("dbo.Employees", new[] { "PositionId" });
            DropIndex("dbo.Directions", new[] { "FacultetId" });
            DropIndex("dbo.BankAccounts", new[] { "GetBank_BankId" });
            DropTable("dbo.Valutas");
            DropTable("dbo.Users");
            DropTable("dbo.StudentDMs");
            DropTable("dbo.SalaryEmployees");
            DropTable("dbo.Salaries");
            DropTable("dbo.Оrganizations");
            DropTable("dbo.Positions");
            DropTable("dbo.Employees");
            DropTable("dbo.Facultets");
            DropTable("dbo.Directions");
            DropTable("dbo.Banks");
            DropTable("dbo.BankAccounts");
        }
    }
}
