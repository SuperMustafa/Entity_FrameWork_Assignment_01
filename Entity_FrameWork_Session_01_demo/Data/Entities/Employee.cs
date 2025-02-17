using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session_01_demo.Data.Entities
{
    internal class Employee
    {
        #region [By convension ]
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public decimal Salary { get; set; }
        //public int Age { get; set; }
        #endregion
        #region [By Data Annotation]
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[Required]
        //[StringLength(50,MinimumLength =10)]
        public string? EmpName { get; set; }

        //[Required]
        //[DataType(DataType.EmailAddress)]
        //[StringLength(50,MinimumLength =10)]
        public string? Email { get; set; }
        //[DataType(DataType.Password)]
        public string? Password { get; set; }

        //[Column(TypeName ="Money")]
        //[DataType(DataType.Currency)] e
        public decimal Salary { get; set; }
        public string? Address { get; set; }

        //[Range(21,60)]
        public int? Age { get; set; }

        //[DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        public int DepartmentDeptId { get; set; }


        #region [relationships]
        //====================== work relation   =========================]
        // ====================== navigational property =============================
        [InverseProperty(nameof(Entities.Department.Employees ))]
        public Department Department { get; set; } // here we set a one relation ship that mean every
                                                   // employee works on one department[
        //[ForeignKey(nameof(Employee.Department))]
        //public int DepartmentId { get; set; }
        //==================== work relation ======================



        //===================== manage relation====================
        //[InverseProperty(nameof(Entities.Department.Manager))]
        //public Department? ManagedDepartment { get; set; }


        //[ForeignKey(nameof(Employee.ManagedDepartment))]
        //public int ManagedDepartmentID { get; set; }

        //===================== manage relation====================
        //public Address EmployeeAddress { get; set; }
        #endregion
        #endregion

    }
}
