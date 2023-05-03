/*
* Author: Jyad Aljohani
* File name: BrontowurstUnitTests.cs
* Purpose: To unit test the Brontowurst class
*/
using System;
using Xunit;
using DinoDiner.Data.Entrees;
using System.ComponentModel;


namespace DataTest
{

    /// <summary>
    /// Unit tests for Brontowurst
    /// </summary>
    public class BrontowurstUnitTests 
    {
        /// <summary>
        /// Checks that Brontowurst class inherit from Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree() {

            Brontowurst bros = new();
            Assert.IsAssignableFrom<Entree>(bros);
        }

        /// <summary>
        /// Checks the Name to be correct
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            Brontowurst bros = new();
            Assert.Equal("Brontowurst", bros.Name);


        }
        /// <summary>
        /// Price should always be $5.86
        /// </summary>
        /// <param name="onions">If Brontowurst contains onions</param>
        /// <param name="peppers">If Brontowurst contains peppers</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void PriceShouldBeCorrect(bool onions, bool peppers)
        {
            Brontowurst bros = new()
            {
                Onions = onions,
                Peppers = peppers
            };
            Assert.Equal(5.86m, bros.Price);
        }

        /// <summary>
        /// Checks the calories 
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {

            Brontowurst bros = new();
            Assert.Equal((uint)512u, bros.Calories);
        }

        /// <summary>
        /// Checks that the Onions should be true
        /// </summary>
        [Fact]
        public void OnionsShouldDefaultToTrue()
        {
            Brontowurst bros = new();
            Assert.True(bros.Onions);

        }

        /// <summary>
        /// Checks that the Onions can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            Brontowurst bros = new();
            bros.Onions = false;
            Assert.False(bros.Onions);
            bros.Onions = true;
            Assert.True(bros.Onions);

        }

        /// <summary>
        /// Checks that the Peppers should be true
        /// </summary>
        [Fact]
        public void PeppersShouldDefaultToTrue()
        {
            Brontowurst bros = new();
            Assert.True(bros.Peppers);

        }

        /// <summary>
        /// Checks that the Peppers can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPeppers()
        {
            Brontowurst bros = new();
            bros.Onions = false;
            Assert.False(bros.Onions); 
            bros.Onions = true;
            Assert.True(bros.Onions); 

        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Brontowurst bros = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bros);
        }

        /// <summary>
        /// Checks notification of property Changed when Onions changes.
        /// </summary>
        /// <param name="Onions">Whether the order has Onions</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(true, "Onions")]
        [InlineData(false, "Onions")]
        public void ShouldNotifyOfPropertyChangedWhenOnionsChanges(bool Onions, string propertyName)
        {
            Brontowurst bros = new();
            // A quick hack to avoid not changing Onions when setting to the default Onions.
            if (Onions) bros.Onions = false;
            Assert.PropertyChanged(bros, propertyName, () =>
            {
                bros.Onions = Onions;
            });
        }


        /// <summary>
        /// Checks notification of property Changed when Peppers changes.
        /// </summary>
        /// <param name="Peppers">Whether the order has Peppers</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(true, "Peppers")]
        [InlineData(false, "Peppers")]
        public void ShouldNotifyOfPropertyChangedWhenPeppersChanges(bool Peppers, string propertyName)
        {
            Brontowurst bros = new();
            // A quick hack to avoid not changing peppers when setting to the peppers pita.
            if (Peppers) bros.Peppers = false;
            Assert.PropertyChanged(bros, propertyName, () =>
            {
                bros.Peppers = Peppers;
            });
        }

        /// <summary>
        /// Checks whether the overridden method ToString() returns the expected value.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            Brontowurst bros = new();
            Assert.Equal($"{bros.Name}", bros.ToString());
        }

    }
}
