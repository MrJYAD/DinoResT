/*
* Author: Jyad Aljohani
* File name: DinoNuggetsUnitTests.cs
* Purpose: To unit test the DinoNuggets class
*/

using System;
using Xunit;
using DinoDiner.Data.Entrees;
using System.ComponentModel;

namespace DataTest
{
    /// <summary>
    /// Unit tests for DinoNuggets
    /// </summary>
    public class DinoNuggetsUnitTests
    {
        /// <summary>
        /// Checks that DinoNuggets class inherit from Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            DinoNuggets Nug = new();
            Assert.IsAssignableFrom<Entree>(Nug);
        }

        /// <summary>
        /// Checks the Name
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            DinoNuggets Nug = new();
            Assert.Equal($"{Nug.Count} Dino Nuggets", Nug.Name);
        }

        /// <summary>
        /// Checks the Price
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            DinoNuggets Nug = new();
            Assert.Equal(Nug.Count*0.25m, Nug.Price);
        }

        /// <summary>
        /// Checks the calories based on the sauce
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            DinoNuggets Nug = new();
            Assert.Equal((uint)61u * Nug.Count, Nug.Calories);
        }

        /// <summary>
        /// Checks the patties
        /// </summary>
        [Fact]
        public void CountShouldDefaultToSix()
        {
            DinoNuggets Nug = new();
            Assert.Equal(6u, Nug.Count);
        }
        /// <summary>
        /// Checks that the <paramref name="count"/> can be set3
        /// </summary>
        /// <param name="count">The count to set</param>
        [Theory]
        [InlineData(6)]
        public void ShouldBeAbleToSetCount(uint count)       
        {
            DinoNuggets Nug = new();
            Nug.Count = count;
            Assert.Equal(count, Nug.Count);
        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            DinoNuggets Nug = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(Nug);
        }

        /// <summary>
        /// Checks whether the overridden method ToString() returns the expected value.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            DinoNuggets Nug = new();
            Assert.Equal($"{Nug.Name}", Nug.ToString());
        }
    }
}
