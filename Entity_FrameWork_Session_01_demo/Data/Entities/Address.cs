using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity_FrameWork_Session_01_demo.Data.Entities
{
    [Owned]
    internal class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int BlockNumber { get; set; }

    }
}
