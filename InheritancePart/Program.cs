using InheritancePart.Data.Context;
using InheritancePart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InheritancePart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [TPCC -- Table per Concrete Class (inheritance way)]
            //using MyCompany02DbContext DbContext = new MyCompany02DbContext();

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{ Name = "Mustafa", Age = 26, Address = "Sadat City", HiringDate = DateTime.Now, Salary = 4500 };
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{ Name = "Rewan", Age = 22, Address = "Alex", CountOfHours = 200, HourRate = 5 };
            //DbContext.FullTimeEmployees.Add(fullTimeEmployee);
            //DbContext.PartTimeEmployees.Add(partTimeEmployee);

            //DbContext.SaveChanges();
            //var FullEmployee = from FtEmployee in DbContext.FullTimeEmployees
            //                   select FtEmployee;
            //foreach (var item in FullEmployee)
            //{
            //    Console.WriteLine($"Full time Employee Name is : {item.Name} Full time Employee Hiring Date is :{item.HiringDate} ");

            //}
            //var PartTimeEmployee = from PTEmployee in DbContext.PartTimeEmployees
            //                       select PTEmployee;
            //foreach (var item in PartTimeEmployee)
            //{
            //    Console.WriteLine($"Part time Employee Name is : {item.Name} Full time Employee Hour Rate is :{item.HourRate} ");

            //}
            #endregion
            #region [TPH -- table per herirachy]
            using MyCompany02DbContext DbContext = new MyCompany02DbContext();

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            { Name = "Mohamed", Age = 40, Address = "shibin", HiringDate = DateTime.Now, Salary = 10000 };
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            { Name = "Noha", Age = 20, Address = "Quesna", CountOfHours = 200, HourRate = 7 };
            DbContext.FullTimeEmployees.Add(fullTimeEmployee);
            DbContext.PartTimeEmployees.Add(partTimeEmployee);
            DbContext.SaveChanges();

            #endregion

        }

    }
}
