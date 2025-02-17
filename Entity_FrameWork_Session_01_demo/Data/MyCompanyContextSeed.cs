using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Entity_FrameWork_Session_01_demo.Data;
using Entity_FrameWork_Session_01_demo.Data.Context;
using Entity_FrameWork_Session_01_demo.Data.Entities;

namespace Entity_FrameWork_Session_01_demo.Data
{
    internal static class MyCompanyContextSeed
    {
        public static void Seed(MyCompanyDbContext dbContext)
        {
            var DepartmentFile = File.ReadAllText("E:\\asp.net\\Assignments\\Entity_FrameWork\\Entity_FrameWork_Session_01\\Entity_FrameWork_Session_01_demo\\Data\\DataSeed\\departments.json");
            var Departments = JsonSerializer.Deserialize<List<Department>>(DepartmentFile);
            if (!dbContext.Departments.Any())
            {
                if (Departments.Count() > 0)
                {
                    foreach (var department in Departments)
                    {

                        dbContext.Departments.Add(department);

                    }
                    dbContext.SaveChanges();

                }
            }

            var EmployeeFile = File.ReadAllText("E:\\asp.net\\Assignments\\Entity_FrameWork\\Entity_FrameWork_Session_01\\Entity_FrameWork_Session_01_demo\\Data\\DataSeed\\employees.json");
            var Employees = JsonSerializer.Deserialize<List<Employee>>(EmployeeFile);

           
            if (!dbContext.Employees.Any())
            {
                if (Employees.Count() > 0)
                {
                    foreach (var employee in Employees)
                    {

                        dbContext.Employees.Add(employee);

                    }
                    dbContext.SaveChanges();

                }
            }
        }
    }
}
