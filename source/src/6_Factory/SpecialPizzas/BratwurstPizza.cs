using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._6_Factory
{
    public class BratwurstPizza : IPizza
    {
        public string Name => "Bratwurst Pizza";

        public List<string> Ingredients => new List<string>(["St. Galler Olma Bratwurst", "Tomatensauce", "Mozzarella"]);
    }
}
