namespace DesignPatterns.Tests;

using FluentAssertions;
using Microsoft.Extensions.Time.Testing;

public class SaleTests : IDisposable
{
    public SaleTests()
    {
        // Setup
    }

    public void Dispose()
    {
        // TearDown
    }

    [Fact]
    public void GetTotal_WithPercentageStrategy_ReturnCorrectTotal()
    {
        // Arrange
        var strategy = new PercentageSalePricingStrategy(10);
        var sale = new Sale(100m, strategy);

        // Act
        var total = sale.GetTotal();

        // Assert
        total.Should().Be(90);
    }
    [Fact]
    public void GetTotal_WithAmountBasedStrategyBelowThreshold_ReturnCorrectTotal()
    {
        // Arrange
        var strategy = new AmountBasedSalePricingStrategy(5, 200, 20);
        var sale = new Sale(100m, strategy);

        // Act
        var total = sale.GetTotal();

        // Assert
        total.Should().Be(95);
    }
    [Fact]
    public void GetTotal_WithAmountBasedStrategyAboveThreshold_ReturnCorrectTotal()
    {
        // Arrange
        var strategy = new AmountBasedSalePricingStrategy(5, 200, 20);
        var sale = new Sale(250m, strategy);

        // Act
        var total = sale.GetTotal();

        // Assert
        total.Should().Be(230);

    }
    [Fact]
    public void GetTotal_WithTimeBasedStrategyDefaultDiscount_ReturnCorrectTotal()
    {
        // Arrange
        var fake = new FakeTimeProvider();
        fake.SetUtcNow(new DateTimeOffset(2030, 5, 10, 11, 59, 59, TimeSpan.Zero));
        var strategy = new TimeBasedSalePricingStrategy(5, new TimeOnly(12, 0, 0), fake);
        var sale = new Sale(1000m, strategy);

        // Act
        var total = sale.GetTotal();

        // Assert
        total.Should().Be(950);

    }
    [Fact]
    public void GetTotal_WithTimeBasedStrategyIncreasedDiscount_ReturnCorrectTotal()
    {
        // Arrange
        var fake = new FakeTimeProvider();
        fake.SetUtcNow(new DateTimeOffset(2030, 5, 10, 12, 0, 0, TimeSpan.Zero));
        var strategy = new TimeBasedSalePricingStrategy(5, new TimeOnly(12, 0, 0), fake);
        var sale = new Sale(1000m, strategy);

        // Act
        var total = sale.GetTotal();

        // Assert
        total.Should().Be(900);

    }
}
