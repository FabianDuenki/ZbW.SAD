using DesignPatterns._6_Factory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._6_Factory
{
    public abstract class PizzaStoreAbstractFactory
    {
        public abstract IPizza Create();
        public static IPizza CreatePizza(string city)
        {
            switch(city)
            {
                case "Valencia":
                    return new ValenciaStoreFactory().Create();
                case "St. Gallen":
                    return new StGallenStoreFactory().Create();
                default:
                    return new MargheritaPizza();
            }
        }
    }
}
