using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePart.Data.Entities
{
    internal class FullTimeEmployee : Employee
    {
        public DateTime HiringDate { get; set; }
        public decimal Salary { get; set; }
    }
}
