/*
* Author: Jyad Aljohani
* File name: CretaceousCoffeeUnitTests.cs
* Purpose: To unit test the CretaceousCoffee class
*/
using System;
using Xunit;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Drinks;
using System.ComponentModel;

namespace DataTest
{
    /// <summary>
    /// Unit tests for CretaceousCoffee
    /// </summary>
    public class CrustaceousCoffeeUnitTests
    {

        /// <summary>
        /// Checks that CretaceousCoffee class inherit from Drink
        /// </summary>
        [Fact]
        public void ShouldInheritFromcoffee()
        {
            CrustaceousCoffee coffee = new();
            Assert.IsAssignableFrom<Drink>(coffee);
        }

        /// <summary>
        /// Checks the name based on the serving size
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="name">The expected size</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Coffee")]     
        [InlineData(ServingSize.Medium, "Medium Coffee")]
        [InlineData(ServingSize.Large, "Large Coffee")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            CrustaceousCoffee coffee = new()
            {
                Size = size
            };
            Assert.Equal(name, coffee.Name);
        }

        /// <summary>
        /// Checks the price based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(ServingSize.Small, 0.75)]
        [InlineData(ServingSize.Medium, 1.25)]
        [InlineData(ServingSize.Large, 2.00)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            CrustaceousCoffee coffee = new()
            {
                Size = size
            };
            Assert.Equal(price, coffee.Price);
        }

        /// <summary>
        /// Checks the calories based on the flavor and cream
        /// </summary>
        /// <param name="cream">The cream to check</param>
        /// <param name="size">The size to check</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(true ,ServingSize.Small, 64u)]
        [InlineData(true,ServingSize.Medium, 64u)] 
        [InlineData(true,ServingSize.Large, 64u)] 

        [InlineData(false, ServingSize.Small, 0u)]  
        [InlineData(false, ServingSize.Medium, 0u)] 
        [InlineData(false, ServingSize.Large, 0u)] 
        public void CaloriesShouldBeCorrect(bool cream, ServingSize size, uint calories)
        {
            CrustaceousCoffee coffee = new()
            {
                Cream = cream,
                Size = size
            };
            Assert.Equal(calories, coffee.Calories);
        }

        /// <summary>
        /// Checks that the <paramref name="size"/> can be set
        /// </summary>
        /// <param name="size">The size to use</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ShouldBeAbleToSetSize(ServingSize size)
        {
            CrustaceousCoffee coffee = new();
            coffee.Size = size;
            Assert.Equal(size, coffee.Size);
        }

        /// <summary>
        /// Checks that the Cream should be False
        /// </summary>
        [Fact]
        public void CreamShouldDefaultToFalse()
        {
            CrustaceousCoffee coffee = new();
            Assert.False(coffee.Cream);

        }

        /// <summary>
        /// Checks that the Cream can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCream()   
        {
            CrustaceousCoffee coffee = new();
            coffee.Cream = false;
            Assert.False(coffee.Cream);     
            coffee.Cream = true;
            Assert.True(coffee.Cream);    

        }
        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            CrustaceousCoffee coffee = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }
        /// <summary>
        /// Checks notification of property Changed when cream changes.
        /// </summary>
        /// <param name="cream">Whether cream is added to the order</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(false, "Cream")]
        [InlineData(true, "Cream")]
        [InlineData(false, "Calories")]
        [InlineData(true, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenCreamChanges(bool cream, string propertyName)
        {
            CrustaceousCoffee coffee = new();
            // A quick hack to avoid not changing cream when setting to the default cream.
            if (!cream) coffee.Cream = true;
            Assert.PropertyChanged(coffee, propertyName, () =>
            {
                coffee.Cream = cream;
            });
        }


        /// <summary>
        /// Checks notification of property Changed when size changes.
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(ServingSize.Small, "Size")]
        [InlineData(ServingSize.Medium, "Size")]
        [InlineData(ServingSize.Large, "Size")]
        [InlineData(ServingSize.Small, "Name")]
        [InlineData(ServingSize.Medium, "Name")]
        [InlineData(ServingSize.Large, "Name")]
        [InlineData(ServingSize.Small, "Price")]
        [InlineData(ServingSize.Medium, "Price")]
        [InlineData(ServingSize.Large, "Price")]

        public void ShouldNotifyOfPropertyChangedWhenSizeChanges(ServingSize size, string propertyName)
        {
            CrustaceousCoffee drink = new();
            // A quick hack to avoid not changing size when setting to the default size.
            if (size == ServingSize.Small) drink.Size = ServingSize.Large;
            Assert.PropertyChanged(drink, propertyName, () =>
            {
                drink.Size = size;
            });
        }

        /// <summary>
        /// Checks the calories based on the flavor and cream
        /// </summary>
        /// <param name="cream">The cream to check</param>
        /// <param name="size">The size to check</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(true, ServingSize.Small, "Small Coffee")]
        [InlineData(true, ServingSize.Medium, "Medium Coffee")]
        [InlineData(true, ServingSize.Large, "Large Coffee")]
        [InlineData(false, ServingSize.Small, "Small Coffee")]
        [InlineData(false, ServingSize.Medium, "Medium Coffee")]
        [InlineData(false, ServingSize.Large, "Large Coffee")]
        public void ToStringShouldReturnExpectedValue( bool cream, ServingSize size, string expectedName)
        {
            CrustaceousCoffee drink = new()
            {
                Cream = cream,
                Size = size
            };
            Assert.Equal(expectedName, drink.ToString());
        }

    }
}
