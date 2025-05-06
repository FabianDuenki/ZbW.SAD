
namespace DesignPatterns.Tests
{
    public class AmountBasedSalePricingStrategy : ISalePricingStrategy
    {
        private int _initialDiscount;
        private int _threshold;
        private int _increasedDiscount;
        public AmountBasedSalePricingStrategy(int initialDiscount, int threshold, int increasedDiscount)
        {
            _initialDiscount = initialDiscount;
            _threshold = threshold;
            _increasedDiscount = increasedDiscount;
        }
        public decimal GetTotalIncludingDiscount(Sale sale)
        {
            if (sale.Amount < this._threshold)
            {
                return sale.Amount - this._initialDiscount;
            }
            else
            {
                return sale.Amount - this._increasedDiscount;
            }
        }
    }
}