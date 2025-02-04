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
            using MyCompanyDbContext dbContext = new MyCompanyDbContext();
            dbContext.Employees.Add(new Employee { Id = 01, Name = "Mustafa", Salary = 4500, Age = 26 });
            #region [Migretaion]
            // there is two ways to add difference happend in c# project throw database
            //1- Code way
            //dbContext.Database.EnsureCreated();
            //dbContext.Database.EnsureDeleted();

            //2- Command way 
            #endregion
            #endregion


            #endregion
        }
    }
}
