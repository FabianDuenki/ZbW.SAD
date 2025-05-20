using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._6_Factory.Factories
{
    public class ValenciaStoreFactory : PizzaStoreAbstractFactory
    {
        public override IPizza Create()
        {
            return new PaellaPizza();
        }
    }
}
