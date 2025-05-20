using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._5_Decorator
{
    public class TimeMeasurementDecorator : ISalePricingStrategy
    {
        private ISalePricingStrategy _strategy;
        public TimeMeasurementDecorator(ISalePricingStrategy salePricingStrategy)
        {
            this._strategy = salePricingStrategy;
        }
        public decimal GetTotalIncludingDiscount(Sale sale)
        {
            Stopwatch swatch = Stopwatch.StartNew();
            try
            {
                return _strategy.GetTotalIncludingDiscount(sale);
            }
            finally
            {
                var timeInMilliseconds = swatch.ElapsedMilliseconds;
                Console.WriteLine($"It took {timeInMilliseconds}ms");
            }
        }
    }
}
