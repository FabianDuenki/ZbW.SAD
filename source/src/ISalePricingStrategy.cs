using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface ISalePricingStrategy
    {
        decimal GetTotalIncludingDiscount(Sale sale);
    }
}
