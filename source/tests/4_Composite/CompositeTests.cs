namespace DesignPatterns.Tests;

using DesignPatterns._4_Composite;
using FluentAssertions;
using Microsoft.Extensions.Time.Testing;

public class CompositeTests : IDisposable
{
    public CompositeTests()
    {
        // Setup
    }

    public void Dispose()
    {
        // TearDown
    }
    /*
    [Fact]
    public void getTotalIncludingDiscount_WhenGoodForCustomer_ThenLowestTotalReturned()
    {
        // Arrange
        var composite = new BestForCustomerPricingStrategy();
        composite.Add(new AbsoluteDiscountOverThresholdStrategy(100, 10));
        composite.Add(new PercentageSalePricingStrategy(20));

        var sale = new Sale(100m, composite);

        // Act
        var total = sale.GetTotal();

        // Assert
        total.Should().Be(80);
    }

    [Fact]
    public void GetTotalIncludingDiscount_WhenGoodForStore_ThenHighestTotalReturned()
    {
        // Arrange
        var composite = new BestForStorePricingStrategy();
        composite.Add(new AbsoluteDiscountOverThresholdStrategy(100, 10));
        composite.Add(new PercentageSalePricingStrategy(20));

        var sale = new Sale(100m, composite);

        // Act
        var total = sale.GetTotal();

        // Assert
        total.Should().Be(90);
    }
    */
}
