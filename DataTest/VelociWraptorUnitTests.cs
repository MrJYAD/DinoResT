/*
* Author: Jyad Aljohani
* File name: VelociWraptorUnitTests.cs
* Purpose: To unit test the VelociWraptor class
*/
using System;
using Xunit;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using System.ComponentModel;

namespace DataTest
{

    /// <summary>
    /// Unit tests for VelociWraptor
    /// </summary>
    public class VelociWraptorUnitTests
    {
        /// <summary>
        /// Checks that VelociWraptor class inherit from Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {

            VelociWraptor velo = new();
            Assert.IsAssignableFrom<Entree>(velo);
        }

        /// <summary>
        /// Checks the Name to be correct
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            VelociWraptor velo = new();
            Assert.Equal("Veloci-Wraptor", velo.Name);
        }

        /// <summary>
        /// Price should always be $6.25
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            VelociWraptor velo = new();
            Assert.Equal(6.25m, velo.Price);
        }

        /// <summary>
        /// Checks the calories based on the sauce
        /// </summary>
        /// <param name="cheese">The sauce to check</param>
        /// <param name="dressing">The dressing to check</param>
        /// <param name="calories">The expected calories</param>
        [InlineData(true, true,732u)]
        [InlineData(true, false, 732u-94u)]
        [InlineData(false, true, 732u-22u)]
        [InlineData(false, false, 732u-94u-22u)]
        [Theory]
        public void CaloriesShouldBeCorrect( bool cheese, bool dressing, uint calories)
        {
            VelociWraptor velo = new()
            {
                Dressing = dressing,
                Cheese = cheese,
            };
            Assert.Equal(calories, velo.Calories);
        }


        /// <summary>
        /// Checks the Dressing
        /// </summary>
        [Fact]
        public void DressingShouldDefaultToTrue()
        {
            VelociWraptor velo = new();
            Assert.True(velo.Dressing);
        }

        /// <summary>
        /// Checks that the Dressing can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDressing()
        {
            VelociWraptor velo = new();
            velo.Dressing = false;
            Assert.False(velo.Dressing);
            velo.Dressing = true;
            Assert.True(velo.Dressing);
        }

        /// <summary>
        /// Checks that the Cheese should be true
        /// </summary>
        [Fact]
        public void CheeseShouldDefaultToTrue()
        {
            VelociWraptor velo = new();
            Assert.True(velo.Cheese);
        }

        /// <summary>
        /// Checks that the Cheese can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()    
        {
            VelociWraptor velo = new();
            velo.Cheese = false;
            Assert.False(velo.Cheese);     
            velo.Cheese = true;
            Assert.True(velo.Cheese);    
        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            VelociWraptor velo = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(velo);
        }



        /// <summary>
        /// Checks notification of property Changed when dressing changes.
        /// </summary>
        /// <param name="dressing">Whether dressing is added to the order</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(false, "Dressing")]
        [InlineData(true, "Dressing")]
        [InlineData(false, "Calories")]
        [InlineData(true, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenDressingChanges(bool dressing, string propertyName)
        {
            VelociWraptor velo = new();
            // A quick hack to avoid not changing honey when setting to the default honey.
            if (dressing) velo.Dressing = false;
            Assert.PropertyChanged(velo, propertyName, () =>
            {
                velo.Dressing = dressing;
            });
        }

        /// <summary>
        /// Checks notification of property Changed when dressing changes.
        /// </summary>
        /// <param name="dressing">Whether dressing is added to the order</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(false, "Cheese")]
        [InlineData(true, "Cheese")]
        [InlineData(false, "Calories")]
        [InlineData(true, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenCheeseChanges(bool cheese, string propertyName)
        {
            VelociWraptor velo = new();
            // A quick hack to avoid not changing honey when setting to the default honey.
            if (cheese) velo.Cheese = false;
            Assert.PropertyChanged(velo, propertyName, () =>
            {
                velo.Cheese = cheese;
            });
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
