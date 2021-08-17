using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork03.Models
{
    public class EmployeeDetails
    {
        public string FullEmployeeName { get; set; }

        public Enums.Position Position { get; set; }

        public string DateOfHire { get; set; }

        public string DivisionName { get; set; }
    }
}
