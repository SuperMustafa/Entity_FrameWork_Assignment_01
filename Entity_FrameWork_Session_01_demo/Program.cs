using Entity_FrameWork_Session_01_demo.Data;
using Entity_FrameWork_Session_01_demo.Data.Context;
using Entity_FrameWork_Session_01_demo.Data.Entities;

namespace Entity_FrameWork_Session_01_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ORM--Object Relational mapper]
            // take the classes in c# project and create it at database app as tables or 
            // take the tables from database and create it at c# project 
            // we call the classes from c# at database 
            //1- Entity
            //2- model
            #region [Types of ORM]
            #region [Entity Framework Core(EF) ORM]
            // its syntax is a linq
            // connect to any type of database 
            #endregion
            #region [Dapper ORM]
            // Dapper orm is alight weight orm instead of EF core because in Dapper orm we write like the type of database 
            // syntax ==> if database is sql server we right in C# the syntax of Sqql server
            #endregion
            #endregion
            #endregion
            #region [wayes to transform class  to table at database  ]
            #region [Table per Class (TPC)]
            // each class in C# Project turns to a table at database even if is there was a class inherit from another 
            // orm creats a independant class 
            #endregion
            #region [Table per Heirarchy (TPH)]
            // if Employee The parent of FullTimeEmployee and A perent also of PArtTimeEmployee 
            // Orm Creats one table to all of them and creat at the end column called Discremenator 
            //this way creates very nulls values
            #endregion
            #region [Table per Concrete Class (TPCC)]
            #endregion
            #endregion

            #region [Connect to database]
            #region [By Convesion]
            //using MyCompanyDbContext dbContext = new MyCompanyDbContext();
            //dbContext.Employees.Add(new Employee { EmployeeId = 01, Name = "Mustafa", Salary = 4500, Age = 26 });
            #region [Migretaion]
            // there is two ways to add difference happend in c# project throw database
            //1- Code way
            //dbContext.Database.EnsureCreated();
            //dbContext.Database.EnsureDeleted();

            //2- Command way 
            #endregion
            #region [By Data Annotation ]

            #endregion
            #region [By Configration]
            #endregion
            #region [Fluent Apis]
            #endregion
            #endregion


            #endregion
            #region Crud Operations
            #region [Create]
            //MyCompanyDbContext dbContext = new MyCompanyDbContext();
            //Employee employee01 = new Employee() 
            //{   
            //    Name="Mustafa",
            //    Age=26,
            //    Email="Mustafa@gmail.com",
            //    Password="123456654321",
            //    PhoneNumber="01019540969",
            //    Salary=4500,


            //};
            //Employee employee02 = new Employee()
            //{

            //    Name = "Rewan",
            //    Age = 22,
            //    Email = "rewan@gmail.com",
            //    Password = "123456654321",
            //    PhoneNumber = "01019540969",
            //    Salary = 4500,


            //};
            //Console.WriteLine(dbContext.Entry(employee01).State); //change tracker here its value is deattached
            //Console.WriteLine(dbContext.Entry(employee02).State); //change tracker here its value is deattached

            //============== 4 ways to add entities to data base=========================

            //dbContext.Employees.Add(employee01);
            //dbContext.Employees.Add(employee02);
            ////02--  dbContext.Add(employee02);
            //03--  dbContext.Set<Employee>().Add(employee01);
            //dbContext.Entry(employee01).State = EntityState.added;




            //dbContext.Employees.Add(employee01);
            //dbContext.Employees.Add(employee02);
            //Console.WriteLine(dbContext.Entry(employee01).State);
            //Console.WriteLine(dbContext.Entry(employee02).State);
            //dbContext.SaveChanges();

            #endregion
            #region [Read]
            //var res = (from E in dbContext.Employees
            //          where E.Name=="Mustafa"
            //          select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(res).State);
            //Console.WriteLine($"Employee Id is :{res.EmployeeId} :: Employee Name is : {res.Name}");
            #endregion
            #region [Update]
            //var Employee = (from E in dbContext.Employees
            //           where E.Name == "Mustafa"
            //           select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //if (Employee != null) 

            //{
            //    Employee.Salary = 9000;
            //    Console.WriteLine(dbContext.Entry(Employee).State);

            //}
            //dbContext.SaveChanges();
            #endregion
            #region [Delete]
            //var employee = (from E in dbContext.Employees
            //                where E.Salary == 4500
            //                select E).FirstOrDefault();
            //dbContext.Employees.Remove(employee);
            //Console.WriteLine(dbContext.Entry(employee).State);
            //dbContext.SaveChanges();
            #endregion
            #endregion

            #region 

            MyCompanyDbContext dbContext = new MyCompanyDbContext();
            Employee Emp01= new Employee() { EmpName="Mustafa",Age=26,PhoneNumber="0101954096" 
                ,Email="Mustafa@gmail.com",Salary=4500,DepartmentDeptId=1,Address="Sadat City",Password="1111111111", };

            Employee Emp02 = new Employee()
            {
                EmpName = "Rewan",
                Age = 22,
                PhoneNumber = "0101954096"
               ,
                Email = "Rewan@gmail.com",
                Salary = 4500,
                DepartmentDeptId = 1,
                Address = "Alex",
                Password = "2222222222",
            };
            dbContext.Employees.Add(Emp01); 
            dbContext.Employees.Add(Emp02);
            dbContext.SaveChanges();    
            //MyCompanyContextSeed.Seed(dbContext);

            //var Employees = from E in dbContext.Employees
            //                where E.DepartmentDeptId == 1
            //                select E;
            //foreach (var employee in Employees)
            //{
            //    Console.WriteLine($"Employee Name : {employee.EmpName} Department Id : {employee.DepartmentDeptId}");

            //}


        }
        #endregion
    }
    }

