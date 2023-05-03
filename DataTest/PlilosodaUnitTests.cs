/*
* Author: Jyad Aljohani
* File name: PlilosodaUnitTests.cs
* Purpose: To unit test the Plilosoda class
*/
using System;
using Xunit;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Drinks;
using System.ComponentModel;
using System.Drawing;

namespace DataTest
{
    /// <summary>
    /// Unit tests for Plilosoda
    /// </summary>
    public class PlilosodaUnitTests
    {
        /// <summary>
        /// Checks that Plilosoda class inherit from Drink
        /// </summary>
        [Fact]
        public void ShouldInheritFromDrink()
        {
            Plilosoda drink = new();
            Assert.IsAssignableFrom<Drink>(drink);
        }

        /// <summary>
        /// Checks the name based on the flavor and serving size
        /// </summary>
        /// <param name="flavor">The flavor to check</param>
        /// <param name="size">The size to check</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(SodaFlavor.Cola, ServingSize.Small, "Small Cola Plilosoda")]
        [InlineData(SodaFlavor.CherryCola, ServingSize.Small, "Small Cherry Cola Plilosoda")]
        [InlineData(SodaFlavor.DoctorDino, ServingSize.Small, "Small Doctor Dino Plilosoda")]
        [InlineData(SodaFlavor.LemonLime, ServingSize.Small, "Small Lemon-Lime Plilosoda")]
        [InlineData(SodaFlavor.DinoDew, ServingSize.Small, "Small Dino Dew Plilosoda")]

        [InlineData(SodaFlavor.Cola, ServingSize.Medium, "Medium Cola Plilosoda")]
        [InlineData(SodaFlavor.CherryCola, ServingSize.Medium, "Medium Cherry Cola Plilosoda")]
        [InlineData(SodaFlavor.DoctorDino, ServingSize.Medium, "Medium Doctor Dino Plilosoda")]
        [InlineData(SodaFlavor.LemonLime, ServingSize.Medium, "Medium Lemon-Lime Plilosoda")]
        [InlineData(SodaFlavor.DinoDew, ServingSize.Medium, "Medium Dino Dew Plilosoda")]

        [InlineData(SodaFlavor.Cola, ServingSize.Large, "Large Cola Plilosoda")]
        [InlineData(SodaFlavor.CherryCola, ServingSize.Large, "Large Cherry Cola Plilosoda")]
        [InlineData(SodaFlavor.DoctorDino, ServingSize.Large, "Large Doctor Dino Plilosoda")]
        [InlineData(SodaFlavor.LemonLime, ServingSize.Large, "Large Lemon-Lime Plilosoda")]
        [InlineData(SodaFlavor.DinoDew, ServingSize.Large, "Large Dino Dew Plilosoda")]
        public void NameShouldBeCorrect(SodaFlavor flavor, ServingSize size, string name)
        {
            Plilosoda drink = new()
            {
                Flavor = flavor,
                Size = size,
            };
            Assert.Equal(name, drink.Name);
        }

        /// <summary>
        /// Checks the price based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(ServingSize.Small, 1.00)]
        [InlineData(ServingSize.Medium, 1.75)]
        [InlineData(ServingSize.Large, 2.50)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            Plilosoda drink = new()
            {
                Size = size
            };
            Assert.Equal(price, drink.Price);
        }

        /// <summary>
        /// Checks the name based on the flavor and serving size
        /// </summary>
        /// <param name="flavor">The flavor to check</param>
        /// <param name="size">The size to check</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(SodaFlavor.Cola, ServingSize.Small, 180u)]
        [InlineData(SodaFlavor.CherryCola, ServingSize.Small, 100u)]
        [InlineData(SodaFlavor.DoctorDino, ServingSize.Small, 120u)]
        [InlineData(SodaFlavor.LemonLime, ServingSize.Small, 41u)]
        [InlineData(SodaFlavor.DinoDew, ServingSize.Small, 141u)]

        [InlineData(SodaFlavor.Cola, ServingSize.Medium, 288u)]
        [InlineData(SodaFlavor.CherryCola, ServingSize.Medium, 160u)]
        [InlineData(SodaFlavor.DoctorDino, ServingSize.Medium, 192u)]
        [InlineData(SodaFlavor.LemonLime, ServingSize.Medium, 66u)]
        [InlineData(SodaFlavor.DinoDew, ServingSize.Medium, 256u)]

        [InlineData(SodaFlavor.Cola, ServingSize.Large, 432u)]
        [InlineData(SodaFlavor.CherryCola, ServingSize.Large, 240u)]
        [InlineData(SodaFlavor.DoctorDino, ServingSize.Large, 288u)]
        [InlineData(SodaFlavor.LemonLime, ServingSize.Large, 98u)]
        [InlineData(SodaFlavor.DinoDew, ServingSize.Large, 338u)]
        public void CaloriesShouldBeCorrect(SodaFlavor flavor,ServingSize size, uint calories)
        {
            Plilosoda drink = new()
            {
                Flavor = flavor,
                Size = size
            };
            Assert.Equal(calories, drink.Calories);
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
            Plilosoda drink = new();
            drink.Size = size;
            Assert.Equal(size, drink.Size);
        }

        /// <summary>
        /// Checks that the <paramref name="flavor"/> can be set
        /// </summary>
        /// <param name="flavor">The flavor to use</param>
        [Theory]
        [InlineData(SodaFlavor.Cola)]
        [InlineData(SodaFlavor.CherryCola)]
        [InlineData(SodaFlavor.DoctorDino)]
        [InlineData(SodaFlavor.LemonLime)]
        [InlineData(SodaFlavor.DinoDew)]
        public void ShouldBeAbleToSetFlavor(SodaFlavor flavor)
        {
            Plilosoda drink = new();
            drink.Flavor = flavor;
            Assert.Equal(flavor, drink.Flavor);
        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Plilosoda drink = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }


        /// <summary>
        /// Checks notification of property Changed when flavor changes.
        /// </summary>
        /// <param name="flavor">The flavor to check</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(SodaFlavor.Cola, "Flavor")]
        [InlineData(SodaFlavor.CherryCola, "Flavor")]
        [InlineData(SodaFlavor.DoctorDino, "Flavor")]
        [InlineData(SodaFlavor.LemonLime, "Flavor")]
        [InlineData(SodaFlavor.Cola, "Calories")]
        [InlineData(SodaFlavor.CherryCola, "Calories")]
        [InlineData(SodaFlavor.DoctorDino, "Calories")]
        [InlineData(SodaFlavor.LemonLime, "Calories")]
        [InlineData(SodaFlavor.Cola, "Name")]
        [InlineData(SodaFlavor.CherryCola, "Name")]
        [InlineData(SodaFlavor.DoctorDino, "Name")]
        [InlineData(SodaFlavor.LemonLime, "Name")]

        public void ShouldNotifyOfPropertyChangedWhenFlavorChanges(SodaFlavor flavor, string propertyName)
        {
            Plilosoda drink = new();
            // A quick hack to avoid not changing flavor when setting to the default flavor.
            if (flavor == SodaFlavor.Cola) drink.Flavor = SodaFlavor.CherryCola;
            Assert.PropertyChanged(drink, propertyName, () =>
            {
                drink.Flavor = flavor;
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
            Plilosoda drink = new();
            // A quick hack to avoid not changing size when setting to the default size.
            if (size == ServingSize.Small) drink.Size = ServingSize.Large;
            Assert.PropertyChanged(drink, propertyName, () =>
            {
                drink.Size = size;
            });
        }

        /// <summary>
        /// Checks whether the overridden method ToString() returns the expected value.
        /// </summary>
        /// <param name="flavor">The flavor of the order</param>
        /// <param name="size">The size of the order</param>
        /// <param name="expectedName">The expected name of the order</param>
        [Theory]
        [InlineData(SodaFlavor.Cola, ServingSize.Small, "Small Cola Plilosoda")]
        [InlineData(SodaFlavor.CherryCola, ServingSize.Small, "Small Cherry Cola Plilosoda")]
        [InlineData(SodaFlavor.DoctorDino, ServingSize.Small, "Small Doctor Dino Plilosoda")]
        [InlineData(SodaFlavor.LemonLime, ServingSize.Small, "Small Lemon-Lime Plilosoda")]
        [InlineData(SodaFlavor.DinoDew, ServingSize.Small, "Small Dino Dew Plilosoda")]

        [InlineData(SodaFlavor.Cola, ServingSize.Medium, "Medium Cola Plilosoda")]
        [InlineData(SodaFlavor.CherryCola, ServingSize.Medium, "Medium Cherry Cola Plilosoda")]
        [InlineData(SodaFlavor.DoctorDino, ServingSize.Medium, "Medium Doctor Dino Plilosoda")]
        [InlineData(SodaFlavor.LemonLime, ServingSize.Medium, "Medium Lemon-Lime Plilosoda")]
        [InlineData(SodaFlavor.DinoDew, ServingSize.Medium, "Medium Dino Dew Plilosoda")]

        [InlineData(SodaFlavor.Cola, ServingSize.Large, "Large Cola Plilosoda")]
        [InlineData(SodaFlavor.CherryCola, ServingSize.Large, "Large Cherry Cola Plilosoda")]
        [InlineData(SodaFlavor.DoctorDino, ServingSize.Large, "Large Doctor Dino Plilosoda")]
        [InlineData(SodaFlavor.LemonLime, ServingSize.Large, "Large Lemon-Lime Plilosoda")]
        [InlineData(SodaFlavor.DinoDew, ServingSize.Large, "Large Dino Dew Plilosoda")]
        public void ToStringShouldReturnExpectedValue(SodaFlavor flavor, ServingSize size, string expectedName)
        {
            Plilosoda drink = new()
            {
                Flavor = flavor,
                Size = size
            };
            Assert.Equal(expectedName, drink.ToString());
        }
    }
}
