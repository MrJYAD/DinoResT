/*
* Author: Jyad Aljohani
* File name: MezzorellaSticksUnitTests.cs
* Purpose: To unit test the MezzoreallaSticks class
*/
using System;
using Xunit;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Sides;
using System.ComponentModel;

namespace DataTest
{
    /// <summary>
    /// Unit tests for MezzoreallaSticks
    /// </summary>
    public class MezzorellaSticksUnitTests
    {
        /// <summary>
        /// Checks that MezzoreallaSticks class inherit from Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            MezzoreallaSticks stikcs = new();
            Assert.IsAssignableFrom<Side>(stikcs);
        }

        /// <summary>
        /// Checks the Name
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            MezzoreallaSticks stikcs = new();
            Assert.Equal($"{stikcs.Size} Mezzorella Sticks", stikcs.Name);
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
            MezzoreallaSticks stikcs = new()
            {
                Size = size
            };
            Assert.Equal(price, stikcs.Price);
        }

        /// <summary>
        /// Checks the calories based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(ServingSize.Small, 530u)]
        [InlineData(ServingSize.Medium, 620u)]
        [InlineData(ServingSize.Large, 730u)]
        public void CaloriesShouldBeCorrect(ServingSize size, uint calories)
        {
            MezzoreallaSticks stikcs = new()
            {
                Size = size
            };
            Assert.Equal(calories, stikcs.Calories);
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
            MezzoreallaSticks stikcs = new();
            stikcs.Size = size;
            Assert.Equal(size, stikcs.Size);
        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            MezzoreallaSticks stikcs = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(stikcs);
        }

        /// <summary>
        /// Checks whether the overridden method ToString() returns the expected value.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            MezzoreallaSticks stikcs = new();
            Assert.Equal($"{stikcs.Name}", stikcs.ToString());
        }
    }
}
