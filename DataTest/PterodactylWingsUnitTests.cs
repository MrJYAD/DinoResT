/*
* Author: Jyad Aljohani
* File name: PterodactylWingsUnitTests.cs
* Purpose: To unit test the PterodactylWings class
*/
using System;
using Xunit;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Enums;
using System.ComponentModel;

namespace DataTest  
{

    /// <summary>
    /// Unit tests for PterodactylWings
    /// </summary>
    public class PterodactylWingsUnitTests
    {
        /// <summary>
        /// Checks that PterodactylWings class inherit from Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {

            PterodactylWings wing = new();
            Assert.IsAssignableFrom<Entree>(wing);
        }

        /// <summary>
        /// Checks the name based on the flavor and serving size
        /// </summary>
        /// <param name="sauce">The sauce to check</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(WingSauce.Buffalo, "Buffalo Pterodactyl Wings")]
        [InlineData(WingSauce.Teriyaki, "Teriyaki Pterodactyl Wings")]
        [InlineData(WingSauce.HoneyGlaze, "Honey Glaze Pterodactyl Wings")]
        public void NameShouldBeCorrect(WingSauce sauce, string name)
        {
            PterodactylWings wing = new()
            {
                Sauce = sauce

            };
            Assert.Equal(name, wing.Name);
        }

        /// <summary>
        /// Checks the Price
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            PterodactylWings wing = new();
            Assert.Equal(8.95m, wing.Price);
        }

        /// <summary>
        /// Checks the calories based on the sauce
        /// </summary>
        /// <param name="sauce">The sauce to check</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(WingSauce.Buffalo, 360u)]  
        [InlineData(WingSauce.Teriyaki, 342u)] 
        [InlineData(WingSauce.HoneyGlaze, 359u)]  
        public void CaloriesShouldBeCorrect(WingSauce sauce, uint calories)
        {
            PterodactylWings wing = new()
            {
                Sauce = sauce
            };
            Assert.Equal(calories, wing.Calories);
        }

        /// <summary>
        /// Checks the patties
        /// </summary>
        [Fact]
        public void SauceShouldDefaultToBuffalo()
        {
            PterodactylWings wing = new();
            Assert.Equal(WingSauce.Buffalo, wing.Sauce);
        }

        /// <summary>
        /// Checks that the <paramref name="sauce"/> can be set
        /// </summary>
        /// <param name="sauce">The sauce to set</param>
        [Theory]
        [InlineData(WingSauce.Buffalo)]
        [InlineData(WingSauce.Teriyaki)]
        [InlineData(WingSauce.HoneyGlaze)]

        public void ShouldBeAbleToSetSauce(WingSauce sauce)       
        {
            PterodactylWings wing = new()
            {
                Sauce = sauce
            };
            Assert.Equal(sauce, wing.Sauce);

        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            PterodactylWings wing = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(wing);
        }

        /// <summary>
        /// Checks notification of property Changed when meat changes.
        /// </summary>
        /// <param name="sauce">The sauce to check</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(WingSauce.Teriyaki, "Sauce")]
        [InlineData(WingSauce.HoneyGlaze, "Sauce")]
        [InlineData(WingSauce.Buffalo, "Sauce")]
        [InlineData(WingSauce.Teriyaki, "Name")]
        [InlineData(WingSauce.HoneyGlaze, "Name")]
        [InlineData(WingSauce.Buffalo, "Name")]
        [InlineData(WingSauce.Teriyaki, "Calories")]
        [InlineData(WingSauce.HoneyGlaze, "Calories")]
        [InlineData(WingSauce.Buffalo, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenMeatChanges(WingSauce sauce, string propertyName)
        {
            PterodactylWings wing = new();
            // A quick hack to avoid not changing Sauce when setting to the default Sauce.
            if (sauce == WingSauce.Buffalo) wing.Sauce = WingSauce.HoneyGlaze;
            Assert.PropertyChanged(wing, propertyName, () =>
            {
                wing.Sauce = sauce;
            });
        }


    }
}
