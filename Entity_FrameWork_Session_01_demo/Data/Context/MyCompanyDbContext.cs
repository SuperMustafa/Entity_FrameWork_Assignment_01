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
        public DbSet<Department> Departments { get; set; }
        public DbSet<Constructor> Constructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }


        //public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Data Source =. ; IntialCatalog = MyCompany ; Integrated Security= true"); // old syntax
            optionsBuilder.UseSqlServer("Server = . ; Database = MyCompany ; Trusted_Connection=True ; TrustServerCertificate= True"); 
        }

        #region [Fluent apis]
        #region First overLoad to Entity method
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().Property((P) => P.Name).IsRequired(false).HasDefaultValue("TestEmployee");
        //    modelBuilder.Entity<Employee>().HasKey(p => p.EmployeeId); //ASsign as primary key

        //    modelBuilder.Entity<Employee>().Property((P) => P.EmployeeId).UseIdentityColumn(1, 1);
        //    modelBuilder.Entity<Employee>().Property((P) => P.Email).IsRequired(true);
        //    modelBuilder.Entity<Employee>().Property((P) => P.PhoneNumber).IsRequired(true);
        //    modelBuilder.Entity<Employee>().Property((P) => P.Age).IsRequired(true);

        //    //modelBuilder.Entity<Constructor>().ToTable("Constructors", "dbo");  ==> Another syntax to create a table to this entity at database
        //    modelBuilder.Entity<Constructor>().HasKey((C) => C.Id);
        //    modelBuilder.Entity<Constructor>().Property((P => P.Id)).UseIdentityColumn(10, 10);
        //    modelBuilder.Entity<Constructor>().Property((P) => P.Name).IsRequired(true).HasDefaultValue("TestName");
        //    modelBuilder.Entity<Constructor>().Property((P) => P.Salary).IsRequired(true);

        //}


        #endregion
        #region Second overLoad to Entity method
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>(E =>
        //    {
        //        E.Property(E => E.Name)
        //        .IsRequired(false).HasDefaultValue("TestEmployee");
        //        E.Property((E) => E.EmployeeId)
        //        .UseIdentityColumn(1, 1);

        //        E.Property((E) => E.Email)
        //        .IsRequired(true);
        //        E.Property((E)=>E.PhoneNumber) .IsRequired(true);
        //        E.Property((E)=>E.Age).IsRequired(true);


        //    });
          
           
            
            
            
            //modelBuilder.Entity<Employee>().Property((P) => P.Name).IsRequired(false).HasDefaultValue("TestEmployee");
            //modelBuilder.Entity<Employee>().HasKey(p => p.EmployeeId); //ASsign as primary key

            //modelBuilder.Entity<Employee>().Property((P) => P.EmployeeId).UseIdentityColumn(1, 1);
            //modelBuilder.Entity<Employee>().Property((P) => P.Email).IsRequired(true);
            //modelBuilder.Entity<Employee>().Property((P) => P.PhoneNumber).IsRequired(true);
            //modelBuilder.Entity<Employee>().Property((P) => P.Age).IsRequired(true);

            //modelBuilder.Entity<Constructor>().ToTable("Constructors", "dbo");  ==> Another syntax to create a table to this entity at database
            //modelBuilder.Entity<Constructor>().HasKey((C) => C.Id);
            //modelBuilder.Entity<Constructor>().Property((P => P.Id)).UseIdentityColumn(10, 10);
            //modelBuilder.Entity<Constructor>().Property((P) => P.Name).IsRequired(true).HasDefaultValue("TestName");
            //modelBuilder.Entity<Constructor>().Property((P) => P.Salary).IsRequired(true);

        }
        #endregion

        #endregion

    }
//}
