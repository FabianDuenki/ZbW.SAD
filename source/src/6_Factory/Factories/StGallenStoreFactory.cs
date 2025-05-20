using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._6_Factory.Factories
{
    public class StGallenStoreFactory : PizzaStoreAbstractFactory
    {
        public override IPizza Create()
        {
            return new BratwurstPizza();
        }
    }
}
