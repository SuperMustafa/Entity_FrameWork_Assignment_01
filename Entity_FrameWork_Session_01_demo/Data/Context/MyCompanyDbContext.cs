using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_FrameWork_Session_01_demo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entity_FrameWork_Session_01_demo.Data.Context
{
    internal class MyCompanyDbContext:DbContext
    {
        public DbSet <Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Data Source =. ; IntialCatalog = MyCompany ; Integrated Security= true"); // old syntax
            optionsBuilder.UseSqlServer("Server = . ; Database = MyCompany ; Trusted_Connection=True ; TrustServerCertificate= True"); 
        }

    }
}
