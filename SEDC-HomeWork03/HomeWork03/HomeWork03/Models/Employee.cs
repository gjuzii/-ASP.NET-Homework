using HomeWork03.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork03.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateOfHire { get; set; }

        public Position Position { get; set; }
        
        public int Salary { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetPosition(Position position)
        {
            return position.ToString();
        }

        public Employee(int employeeId, string firstName, string lastName, string dateOfHire, Position position, int salary)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            DateOfHire = dateOfHire;
            Position = position;
            Salary = salary;
        }
    }
}
