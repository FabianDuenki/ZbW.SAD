using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._6_Factory
{
    public class PaellaPizza : IPizza
    {
        public string Name => throw new NotImplementedException();

        public List<string> Ingredients => new List<string>(["Paella", "Tomatensauce", "Mozzarella"]);
    }
}
