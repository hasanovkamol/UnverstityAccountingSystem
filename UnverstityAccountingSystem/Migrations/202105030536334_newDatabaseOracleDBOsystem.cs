namespace UnverstityAccountingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDatabaseOracleDBOsystem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DBOSYSTEM.Банксчета",
                c => new
                    {
                        BankAccountId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Valuta = c.String(),
                        AccountNumber = c.String(),
                        Name = c.String(),
                        DateofContract = c.DateTime(nullable: false),
                        ContracTerminationDate = c.DateTime(nullable: false),
                        AccountBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GetBank_BankId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.BankAccountId)
                .ForeignKey("DBOSYSTEM.Банки", t => t.GetBank_BankId)
                .Index(t => t.GetBank_BankId);
            
            CreateTable(
                "DBOSYSTEM.Банки",
                c => new
                    {
                        BankId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        MFO = c.String(),
                        Telefon = c.String(),
                    })
                .PrimaryKey(t => t.BankId);
            
            CreateTable(
                "DBOSYSTEM.Направление",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        FacultetId = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("DBOSYSTEM.Факультеты", t => t.FacultetId, cascadeDelete: true)
                .Index(t => t.FacultetId);
            
            CreateTable(
                "DBOSYSTEM.Факультеты",
                c => new
                    {
                        FacultetId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.FacultetId);
            
            CreateTable(
                "DBOSYSTEM.Сотрудники",
                c => new
                    {
                        EmployeeId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
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
                        PositionId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Workplace = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("DBOSYSTEM.Должности", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId);
            
            CreateTable(
                "DBOSYSTEM.Должности",
                c => new
                    {
                        PositionId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        Decreption = c.String(),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "DBOSYSTEM.Организации",
                c => new
                    {
                        OrganizationId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        INN = c.String(),
                        Address = c.String(),
                        Telefon = c.String(),
                        NomerGost = c.String(),
                        NomerGostDate = c.DateTime(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        BankAccount_BankAccountId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.OrganizationId)
                .ForeignKey("DBOSYSTEM.Банксчета", t => t.BankAccount_BankAccountId)
                .Index(t => t.BankAccount_BankAccountId);
            
            CreateTable(
                "DBOSYSTEM.Salaries",
                c => new
                    {
                        SalaryId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        SalaryTimeTo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SalaryId);
            
            CreateTable(
                "DBOSYSTEM.SalaryEmployees",
                c => new
                    {
                        SalaryEmployeeId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        EmployeeId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        INNPS = c.Double(nullable: false),
                        ENDF = c.Double(nullable: false),
                        ESP = c.Double(nullable: false),
                        SalaryId = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.SalaryEmployeeId)
                .ForeignKey("DBOSYSTEM.Salaries", t => t.SalaryId, cascadeDelete: true)
                .Index(t => t.SalaryId);
            
            CreateTable(
                "DBOSYSTEM.Студент",
                c => new
                    {
                        StudentId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Course = c.Decimal(nullable: false, precision: 10, scale: 0),
                        FacultetSt = c.String(),
                        EducationalDirectionSt = c.String(),
                        PaymentAgreement = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Scholarship = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Payment = c.Decimal(nullable: false, precision: 1, scale: 0),
                        ContractMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "DBOSYSTEM.Users",
                c => new
                    {
                        UserId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        UserName = c.String(),
                        UserRoll = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "DBOSYSTEM.Валутас",
                c => new
                    {
                        ValutaId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        ValutaKod = c.String(),
                        Name = c.String(),
                        Descreption = c.String(),
                    })
                .PrimaryKey(t => t.ValutaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("DBOSYSTEM.SalaryEmployees", "SalaryId", "DBOSYSTEM.Salaries");
            DropForeignKey("DBOSYSTEM.Организации", "BankAccount_BankAccountId", "DBOSYSTEM.Банксчета");
            DropForeignKey("DBOSYSTEM.Сотрудники", "PositionId", "DBOSYSTEM.Должности");
            DropForeignKey("DBOSYSTEM.Направление", "FacultetId", "DBOSYSTEM.Факультеты");
            DropForeignKey("DBOSYSTEM.Банксчета", "GetBank_BankId", "DBOSYSTEM.Банки");
            DropIndex("DBOSYSTEM.SalaryEmployees", new[] { "SalaryId" });
            DropIndex("DBOSYSTEM.Организации", new[] { "BankAccount_BankAccountId" });
            DropIndex("DBOSYSTEM.Сотрудники", new[] { "PositionId" });
            DropIndex("DBOSYSTEM.Направление", new[] { "FacultetId" });
            DropIndex("DBOSYSTEM.Банксчета", new[] { "GetBank_BankId" });
            DropTable("DBOSYSTEM.Валутас");
            DropTable("DBOSYSTEM.Users");
            DropTable("DBOSYSTEM.Студент");
            DropTable("DBOSYSTEM.SalaryEmployees");
            DropTable("DBOSYSTEM.Salaries");
            DropTable("DBOSYSTEM.Организации");
            DropTable("DBOSYSTEM.Должности");
            DropTable("DBOSYSTEM.Сотрудники");
            DropTable("DBOSYSTEM.Факультеты");
            DropTable("DBOSYSTEM.Направление");
            DropTable("DBOSYSTEM.Банки");
            DropTable("DBOSYSTEM.Банксчета");
        }
    }
}
