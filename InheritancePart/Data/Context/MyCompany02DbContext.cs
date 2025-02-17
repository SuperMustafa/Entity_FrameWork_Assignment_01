using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritancePart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InheritancePart.Data.Context
{
    internal class MyCompany02DbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = MyCompany02 ; Trusted_Connection=True ; TrustServerCertificate= True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH [Table per Herirachy]

            modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();

            #endregion

        }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; } 

    }
}
