namespace DesignPatterns.Tests;

using DesignPatterns._4_Composite;
using DesignPatterns._6_Factory;
using FluentAssertions;
using Microsoft.Extensions.Time.Testing;

public class FactoryTests
{
    [Fact]
    public void CreatePizza_WhenCityIsValencia_ThenReturnPaellaPizza()
    {
        // Arrange
        string city = "Valencia";

        // Act
        var pizza = PizzaStoreAbstractFactory.CreatePizza(city);


        // Assert
        pizza.Should().BeOfType(typeof(PaellaPizza));

    }
    [Fact]
    public void CreatePizza_WhenCityIsStGallen_ThenReturnBratwurstPizza()
    {
        // Arrange
        string city = "St. Gallen";

        // Act
        var pizza = PizzaStoreAbstractFactory.CreatePizza(city);


        // Assert
        pizza.Should().BeOfType(typeof(BratwurstPizza));

    }
    [Fact]
    public void CreatePizza_WhenCityIsNotHandled_ThenReturnMargheritaPizza()
    {
        // Arrange
        string city = "Bitsch";

        // Act
        var pizza = PizzaStoreAbstractFactory.CreatePizza(city);


        // Assert
        pizza.Should().BeOfType(typeof(MargheritaPizza));

    }
}
