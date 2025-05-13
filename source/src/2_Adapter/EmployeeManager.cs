using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3_Adapter
{
    internal class EmployeeManager
    {
        private List<Employee> _employees = new List<Employee>();
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }
        public void Remove(Employee employee)
        {
            _employees.Remove(employee);
        }

        public decimal PaySalaries()
        {
            return _employees.Sum(e => e.Salary);
        }
    }
}
