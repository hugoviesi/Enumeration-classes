using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumerationClasses.Enum;

namespace EnumerationClasses.Models
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public EmployeeType Type { get; private set; }

        public Employee() { }

        public Employee(int id, string name, EmployeeType type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
