using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_FrameWork_Session_01_demo.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace Entity_FrameWork_Session_01_demo.Data.Configrations
//{
    //internal class EmployeeConfigrations :IEntityTypeConfiguration<Employee>
    //{
        //public void Configure(EntityTypeBuilder<Employee> E)
        //{

            // ==================== syntax of coding relation between two enitites using fluent apis=======================
            //E.HasOne(e => e.Department)
            //  .WithMany(D => D.Employees)
            //  .HasForeignKey(e => e.DepartmentId)
            //  .OnDelete(DeleteBehavior.NoAction);



        //    E.Property(E => E.Name)
        //       .IsRequired(false).HasDefaultValue("TestEmployee");
        //    E.Property((E) => E.EmployeeId)
        //    .UseIdentityColumn(1, 1);

        //    E.Property((E) => E.Email)
        //    .IsRequired(true);
        //    E.Property((E) => E.PhoneNumber).IsRequired(true);
        //    E.Property((E) => E.Age).IsRequired(true);
        //}

       
//    }
//}
