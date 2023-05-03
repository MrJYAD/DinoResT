/*
* Author: Jyad Aljohani
* File name: MeteorMacAndCheeseUnitTests.cs
* Purpose: To unit test the MeteorMacNCheese class
*/
using System;
using Xunit;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Sides;
using System.ComponentModel;

namespace DataTest
{

    /// <summary>
    /// Unit tests for MeteorMacNCheese
    /// </summary>
    public class MeteorMacAndCheeseUnitTests
    {
        /// <summary>
        /// Checks that MeteorMacNCheese class inherit from Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {

            MeteorMacAndCheese mnc = new();
            Assert.IsAssignableFrom<Side>(mnc);
        }

        /// <summary>
        /// Checks the Name
        /// </summary>
        [Theory]
        [InlineData(ServingSize.Small, "Small Meteor Mac & Cheese")]
        [InlineData(ServingSize.Medium, "Medium Meteor Mac & Cheese")]
        [InlineData(ServingSize.Large, "Large Meteor Mac & Cheese")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            MeteorMacAndCheese mnc = new()
            {
                Size = size
            };

            Assert.Equal(name, mnc.Name);
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
            MeteorMacAndCheese mnc = new()
            {
                Size = size
            };
            Assert.Equal(price, mnc.Price);
        }

        /// <summary>
        /// Checks the calories based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(ServingSize.Small, 425u)]
        [InlineData(ServingSize.Medium, 510u)]
        [InlineData(ServingSize.Large, 700u)]
        public void CaloriesShouldBeCorrect(ServingSize size, uint calories)
        {
            MeteorMacAndCheese mnc = new()
            {
                Size = size
            };
            Assert.Equal(calories, mnc.Calories);
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
            MeteorMacAndCheese mnc = new();
            mnc.Size = size;
            Assert.Equal(size, mnc.Size);
        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            MeteorMacAndCheese mnc = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mnc);
        }

        /// <summary>
        /// Checks whether the overridden method ToString() returns the expected value.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            MeteorMacAndCheese mnc = new();
            Assert.Equal($"{mnc.Name}", mnc.ToString());
        }
    }
}
