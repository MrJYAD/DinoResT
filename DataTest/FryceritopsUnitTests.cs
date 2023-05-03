/*
* Author: Jyad Aljohani
* File name: FryceritopsUnitTests.cs
* Purpose: To unit test the Fryceritops class
*/
using System;
using Xunit;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Enums;
using System.ComponentModel;

namespace DataTest
{
    /// <summary>
    /// Unit tests for Fryceritops
    /// </summary>
    public class FryceritopsUnitTests
    {
        /// <summary>
        /// Checks that Fryceritops class inherit from Side.
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {

            Fryceritops fry = new();
            Assert.IsAssignableFrom<Side>(fry);
        }

        /// <summary>
        /// Checks the Name.
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            Fryceritops fry = new();
            Assert.Equal($"{fry.Size} Fryceritops", fry.Name);
        }
        /// <summary>
        /// Checks that the <paramref name="size"/> can be set.
        /// </summary>
        /// <param name="size">The size to use</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ShouldBeAbleToSetSize(ServingSize size)
        {
            Fryceritops fry = new();
            fry.Size = size;
            Assert.Equal(size, fry.Size);
        }

        /// <summary>
        /// Checks the price based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.50)]
        [InlineData(ServingSize.Medium, 4.00)]
        [InlineData(ServingSize.Large, 5.00)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            Fryceritops fry = new()
            {
                Size = size
            };
            Assert.Equal(price, fry.Price);
        }

        /// <summary>
        /// Checks the calories based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="calories">The expected calories</param>
        /// <param name="sauce">The sauce to check</param>
        [Theory]
        [InlineData(ServingSize.Small, 365, false)]
        [InlineData(ServingSize.Medium, 456u, false)]
        [InlineData(ServingSize.Large, 510u, false)]
        [InlineData(ServingSize.Small, 365+80, true)]
        [InlineData(ServingSize.Medium, 456u+80, true)]
        [InlineData(ServingSize.Large, 510u+ 80, true)]
        public void CaloriesShouldBeCorrect(ServingSize size, uint calories , bool sauce)
        {
            Fryceritops fry = new()
            {
                Size = size,
                Sauce =sauce              
            };
            Assert.Equal(calories, fry.Calories);
        }

        /// <summary>
        /// Checks that the Salt should be true
        /// </summary>
        [Fact]
        public void SaltShouldDefaultToTrue()
        {
            Fryceritops fry = new();
            Assert.True(fry.Salt);
        }

        /// <summary>
        /// Checks that the Salt can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSalt()   
        {
            Fryceritops fry = new();
            fry.Salt = false;
            Assert.False(fry.Salt);  
            fry.Salt = true;
            Assert.True(fry.Salt);  
        }

        /// <summary>
        /// Checks that the Sauce should be False
        /// </summary>
        [Fact]
        public void SauceShouldDefaultToFalse()
        {
            Fryceritops fry = new();
            Assert.False(fry.Sauce);
        }

        /// <summary>
        /// Checks that the Sauce can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSauce()   
        {
            Fryceritops fry = new();
            fry.Salt = false;
            Assert.False(fry.Salt);  
            fry.Salt = true;
            Assert.True(fry.Salt);  
        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Fryceritops fry = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fry);
        }


        /// <summary>
        /// Checks notification of property Changed when salt changes.
        /// </summary>
        /// <param name="salt">Whether salt is added to the order</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(false, "Salt")]
        [InlineData(true, "Salt")]
        public void ShouldNotifyOfPropertyChangedWhenSaltChanges(bool salt, string propertyName)
        {
            Fryceritops fry = new();
            // A quick hack to avoid not changing salt when setting to the default salt.
            if (salt) fry.Salt = false;
            Assert.PropertyChanged(fry, propertyName, () =>
            {
                fry.Salt = salt;
            });
        }

        /// <summary>
        /// Checks notification of property Changed when sauce changes.
        /// </summary>
        /// <param name="sauce">Whether sauce is added to the order</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(false, "Sauce")]
        [InlineData(true, "Sauce")]
        [InlineData(false, "Calories")]
        [InlineData(true, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenSauceChanges(bool sauce, string propertyName)
        {
            Fryceritops fry = new();
            // A quick hack to avoid not changing sauce when setting to the default sauce.
            if (!sauce) fry.Sauce = true;
            Assert.PropertyChanged(fry, propertyName, () =>
            {
                fry.Sauce = sauce;
            });
        }

        /// <summary>
        /// Checks whether the overridden method ToString() returns the expected value.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            Fryceritops fry = new();
            Assert.Equal($"{fry.Name}", fry.ToString());
        }

    }
}
