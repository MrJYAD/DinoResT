/*
* Author: Jyad Aljohani
* File name: TriceritotsUnitTests.cs
* Purpose: To unit test the Triceritots class
*/
using System;
using Xunit;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Entrees;
using System.ComponentModel;

namespace DataTest
{

    /// <summary>
    /// Unit tests for Triceritots
    /// </summary>
    public class TriceritotsUnitTests
    {

        /// <summary>
        /// Checks that Triceritots class inherit from Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Triceritots Tri = new();
            Assert.IsAssignableFrom<Side>(Tri);
        }

        /// <summary>
        /// Checks the Name to be correct
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            Triceritots Tri = new();
            Assert.Equal($"{Tri.Size} Triceritots", Tri.Name);
        }

        /// <summary>
        /// Checks the price based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.50)]
        [InlineData(ServingSize.Medium, 4.00)]
        [InlineData(ServingSize.Large, 5.25)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            Triceritots Tri = new()
            {
                Size = size
            };
            Assert.Equal(price, Tri.Price);
        }

        /// <summary>
        /// Checks the calories based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(ServingSize.Small, 351u)]
        [InlineData(ServingSize.Medium, 409u)]
        [InlineData(ServingSize.Large, 583u)]
        public void CaloriesShouldBeCorrect(ServingSize size, uint calories)
        {
            Triceritots Tri = new()
            {
                Size = size
            };
            Assert.Equal(calories, Tri.Calories);
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
            Triceritots Tri = new();
            Tri.Size = size;
            Assert.Equal(size, Tri.Size);
        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Triceritots Tri = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(Tri);
        }

        /// <summary>
        /// Checks whether the overridden method ToString() returns the expected value.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            Triceritots Tri = new();
            Assert.Equal($"{Tri.Name}", Tri.ToString());
        }
    }
}
