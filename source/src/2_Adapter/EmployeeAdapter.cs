using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3_Adapter
{
    public class EmployeeAdapter : Employee
    {
        public EmployeeAdapter(PresidentOfTheBoard p) : base(p.Name, p.Bonus)
        {
            
        }
    }
}
