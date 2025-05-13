using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PercentageSalePricingStrategy : ISalePricingStrategy
    {
        private int _percentage;

        public PercentageSalePricingStrategy(int percentage)
        {
            _percentage = percentage;   
        }
        public decimal GetTotalIncludingDiscount(Sale sale)
        {
            return sale.Amount - (sale.Amount * _percentage / 100);
        }
    }
}
