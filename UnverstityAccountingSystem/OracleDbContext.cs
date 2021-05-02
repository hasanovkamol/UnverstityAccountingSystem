﻿
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using UnverstityAccountingSystem.Data;

namespace UnverstityAccountingSystem
{
    public class OracleDbContext:DbContext
    {
        public OracleDbContext():base("OracleDbContext")
        {
            
            Database.SetInitializer(new DropCreateDatabaseAlways<OracleDbContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("HR");
        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Valuta> Valutas { get; set; }
        public DbSet<StudentDM> StudentDMs { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Facultet> Facultets { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Оrganization> GetОrganizations { get; set; }
        public DbSet<Position>  Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary>  Salaries { get; set; }
        public DbSet<SalaryEmployee>  SalaryEmployees { get; set; }
    }
}
