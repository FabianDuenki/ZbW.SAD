using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3_Adapter
{
    public class Employee
    {
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
}
