using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._6_Factory
{
    public interface IPizza
    {
        public string Name { get; }
        public List<string> Ingredients { get; }
    }
}
