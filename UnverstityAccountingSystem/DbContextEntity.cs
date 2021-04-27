using EntityModel.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EntityModel
{
    public class DbContextEntity:DbContext
    {
        public DbContextEntity():base("dbUnverst")
        {

        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Valuta> Valutas { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<EducationalDirection> EducationalDirections { get; set; }
        public DbSet<Facultet> Facultets { get; set; }
        public DbSet<Оrganization> GetОrganizations { get; set; }
    }
}
