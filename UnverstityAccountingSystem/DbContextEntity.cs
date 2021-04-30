
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using UnverstityAccountingSystem.Data;

namespace UnverstityAccountingSystem
{
    public class DbContextEntity:DbContext
    {
        public DbContextEntity():base("dbUN")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // throw new UnintentionalCodeFirstException();
        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Valuta> Valutas { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Facultet> Facultets { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Оrganization> GetОrganizations { get; set; }
        public DbSet<Position>  Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
