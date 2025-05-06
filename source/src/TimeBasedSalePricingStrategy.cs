
namespace DesignPatterns.Tests
{
    public class TimeBasedSalePricingStrategy : ISalePricingStrategy
    {
        private int _discountPercentage;
        private TimeOnly _timeThreshold;
        private TimeProvider _timeProvider;
        public TimeBasedSalePricingStrategy(int discountPercentage, TimeOnly timeThreshold, TimeProvider timeProvider)
        {
            _discountPercentage = discountPercentage;
            _timeThreshold = timeThreshold;
            _timeProvider = timeProvider;
        }
        public decimal GetTotalIncludingDiscount(Sale sale)
        {
            var actualDiscount = sale.Amount * _discountPercentage / 100;
            if (this._timeProvider.GetLocalNow().TimeOfDay >= this._timeThreshold.ToTimeSpan())
            {
                actualDiscount *= 2;
            }
            return sale.Amount - actualDiscount;
        }
    }
}