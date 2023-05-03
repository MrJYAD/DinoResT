/*
* Author: Jyad Aljohani 
* File name: IndexModelTests.cs
* Purpose: To unit test the IndexModel class
*/

using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using DinoDiner.Data;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Drinks;
using Website.Pages;

namespace WebsiteTests
{
    public class IndexModelTests
    {


        /// <summary>
        /// Checks the search returns coffee
        /// </summary>
        [Fact]
        public void CheckSearchForCoffee()
        {
            var actualResult = Menu.Search("Coffee");
            Assert.Contains(actualResult, item => item is CrustaceousCoffee);
        }


        /// <summary>
        /// Checks the search returns soda
        /// </summary>
        [Fact]
        public void CheckSearchForSoda()
        {
            var actualResult = Menu.Search("soda");
            Assert.Contains(actualResult, item => item is Plilosoda);
        }

        /// <summary>
        /// Checks the search returns AllAmricanBurger
        /// </summary>
        [Fact]
        public void CheckSearchForAllAmrican()
        {
            var actualResult = Menu.Search("All Burger");
            Assert.Contains(actualResult, item => item is AllosaurusAllAmericanBurger);
        }
        /// <summary>
        /// Checks the search returns Brontowurst
        /// </summary>
        [Fact]
        public void CheckSearchForBrontowurst()
        {
            var actualResult = Menu.Search("Brontowurst");
            Assert.Contains(actualResult, item => item is Brontowurst);
        }

        /// <summary>
        /// Checks the search returns double burger
        /// </summary>
        [Fact]
        public void CheckSearchForDouble()
        {
            var actualResult = Menu.Search("double");
            Assert.Contains(actualResult, item => item is DeinonychusDouble);
        }

        /// <summary>
        /// Checks the search returns Cheesbruger
        /// </summary>
        [Fact]
        public void CheckSearchForCheesbruger()
        {
            var actualResult = Menu.Search("cheese");
            Assert.Contains(actualResult, item => item is CarnotaurusCheeseburger);
        }
        
        /// <summary>
        /// Checks the search returns Cheesbruger
        /// </summary>
        [Fact]
        public void CheckSearchForNuggets()
        {
            var actualResult = Menu.Search("nugget");
            Assert.Contains(actualResult, item => item is DinoNuggets);
        }

        /// <summary>
        /// Checks the search returns TRexTriple
        /// </summary>
        [Fact]
        public void CheckSearchForTrexTriple()
        {
            var actualResult = Menu.Search("triple");
            Assert.Contains(actualResult, item => item is TRexTriple);
        }


        /// <summary>
        /// Checks the search returns pbj
        /// </summary>
        [Fact]
        public void CheckSearchForPBJ()
        {
            var actualResult = Menu.Search("pbj");
            Assert.Contains(actualResult, item => item is PrehistoricPBJ);
        }

        /// <summary>
        /// Checks the search returns wings
        /// </summary>
        [Fact]
        public void CheckSearchForWings()
        {
            var actualResult = Menu.Search("wing");
            Assert.Contains(actualResult, item => item is PterodactylWings);
        }
        
        /// <summary>
        /// Checks the search returns wraptor
        /// </summary>
        [Fact]
        public void CheckSearchForWraptor()
        {
            var actualResult = Menu.Search("wrap");
            Assert.Contains(actualResult, item => item is VelociWraptor);
        }

        /// <summary>
        /// Checks the search returns friycertiops
        /// </summary>
        [Fact]
        public void CheckSearchForFri()
        {
            var actualResult = Menu.Search("fry");
            Assert.Contains(actualResult, item => item is Fryceritops);
        }

        /// <summary>
        /// Checks the search returns mac and cheese
        /// </summary>
        [Fact]
        public void CheckSearchForMnC()
        {
            var actualResult = Menu.Search("mac cheese");
            Assert.Contains(actualResult, item => item is MeteorMacAndCheese);
        }

        /// <summary>
        /// Checks the search returns mezzorealla
        /// </summary>
        [Fact]
        public void CheckSearchForMezzorealla()
        {
            var actualResult = Menu.Search("mezzo");
            Assert.Contains(actualResult, item => item is MezzoreallaSticks);
        }

        /// <summary>
        /// Checks the search returns mezzorealla
        /// </summary>
        [Fact]
        public void CheckSearchForTri()
        {
            var actualResult = Menu.Search("Triceri");
            Assert.Contains(actualResult, item => item is Triceritots);
        }



        /// <summary>
        /// Checks the calories filter return the expected values
        /// </summary>
        [Fact]
        public void CheckCaloriesFilter()
        {
            var im = new IndexModel();
            im.OnGet(null, null, 50, 100, null, null);
            Assert.DoesNotContain(im.Items, item => item.Calories < 50);
            Assert.DoesNotContain(im.Items, item => item.Calories > 100);
            Assert.Contains(im.Items, item => item.Calories >= 50);
            Assert.Contains(im.Items, item => item.Calories <= 100);
        }

        /// <summary>
        /// Checks the price filter return the expected values
        /// </summary>
        [Fact]
        public void CheckPriceFilter()
        {
            var im = new IndexModel();
            im.OnGet(null, null, null, null, 1, 5);
            Assert.DoesNotContain(im.Items, item => item.Price < 1);
            Assert.DoesNotContain(im.Items, item => item.Price > 5);
            Assert.Contains(im.Items, item => item.Price >= 1);
            Assert.Contains(im.Items, item => item.Price <= 5);
        }

        /// <summary>
        /// Checks the Entree filter will return only Entrees.
        /// </summary>
        [Fact]
        public void CheckTypeFilterForEntree()
        {
            var im = new IndexModel();
            im.OnGet(null, new string[] { "Entree" }, null, null, null, null);
            Assert.Contains(im.Items, item => item is Entree);
            Assert.DoesNotContain(im.Items, item => item is Side);
            Assert.DoesNotContain(im.Items, item => item is Drink);
        }

        /// <summary>
        /// Checks the Side filter will return only Sides.
        /// </summary>
        [Fact]
        public void CheckTypeFilterForSide()
        {
            var im = new IndexModel();
            im.OnGet(null, new string[] { "Side" }, null, null, null, null);
            Assert.Contains(im.Items, item => item is Side);
            Assert.DoesNotContain(im.Items, item => item is Entree);
            Assert.DoesNotContain(im.Items, item => item is Drink);
        }

        /// <summary>
        /// Checks the Drink filter will return only Drinks.
        /// </summary>
        [Fact]
        public void CheckTypeFilterForDrink()
        {
            var im = new IndexModel();
            im.OnGet(null, new string[] { "Drink" }, null, null, null, null);
            Assert.Contains(im.Items, item => item is Drink);
            Assert.DoesNotContain(im.Items, item => item is Entree);
            Assert.DoesNotContain(im.Items, item => item is Side);
        }
    }
}