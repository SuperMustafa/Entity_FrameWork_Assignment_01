using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session_01_demo.Data.Entities
{
    internal class Department
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }

        //==================== work relation ======================
        [InverseProperty(nameof(Employee.Department))]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        //==================== work relation ======================


        //===================== manage relation====================
        //[InverseProperty(nameof(Employee.ManagedDepartment))]
        //public Employee Manager { get; set; }


        //===================== manage relation====================

    }
}
