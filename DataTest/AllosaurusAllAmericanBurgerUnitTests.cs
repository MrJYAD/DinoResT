/*
* Author: Jyad Aljohani
* File name: AllosaurusAllAmericanBurgerUnitTests.cs
* Purpose: To unit test the AllosaurusAllAmericanBurger class
*/
using System;
using Xunit;
using DinoDiner.Data.Entrees;
using System.ComponentModel;

namespace DataTest
{
    /// <summary>
    /// Unit tests for AllosaurusAllAmericanBurger
    /// </summary>
    public class AllosaurusAllAmericanBurgerUnitTests
    {
        /// <summary>
        /// Checks that AllosaurusAllAmericanBurger class inherit from Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {

            AllosaurusAllAmericanBurger burger =new();
            Assert.IsAssignableFrom<Entree>(burger);
        }

        /// <summary>
        /// Checks the Name to be correct
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.Equal("Allosaurus All-American Burger", burger.Name);
        }


        /// <summary>
        /// Checks the price based on the sauce
        /// </summary>
        /// <param name="ketchup">The ketchup to check</param>
        /// <param name="mustard">The mustard to check</param>
        /// <param name="pickle">The pickle to check</param>
        /// <param name="mayo">The mayo to check</param>
        /// <param name="bbq">The bbq to check</param>
        /// <param name="onion">The onion to check</param>
        /// <param name="tomato">The tomato to check</param>
        /// <param name="lettuce">The lettuce to check</param>
        /// <param name="amricachees">The amricachees to check</param>
        /// <param name="swisscheese">The swisscheese to check</param>
        /// <param name="bacon">The bacon to check</param>
        /// <param name="mushrooms">The mushrooms to check</param>
        /// <param name="price">The expected price</param>
        [InlineData(true, false, false, false, false, false, false, false, false, false, false, false, 1.50 + 0.20)]
        [InlineData(false, true, false, false, false, false, false, false, false, false, false, false, 1.50 + 0.20)]
        [InlineData(false, false, true, false, false, false, false, false, false, false, false, false, 1.50 + 0.20)]
        [InlineData(false, false, false, true, false, false, false, false, false, false, false, false, 1.50 + 0.20)]
        [InlineData(false, false, false, false, true, false, false, false, false, false, false, false, 1.50 + 0.10)]
        [InlineData(false, false, false, false, false, true, false, false, false, false, false, false, 1.50 + 0.40)]
        [InlineData(false, false, false, false, false, false, true, false, false, false, false, false, 1.50 + 0.40)]
        [InlineData(false, false, false, false, false, false, false, true, false, false, false, false, 1.50 + 0.30)]
        [InlineData(false, false, false, false, false, false, false, false, true, false, false, false, 1.50 + 0.25)]
        [InlineData(false, false, false, false, false, false, false, false, false, true, false, false, 1.50 + 0.25)]
        [InlineData(false, false, false, false, false, false, false, false, false, false, true, false, 1.50 + 0.50)]
        [InlineData(false, false, false, false, false, false, false, false, false, false, false, true, 1.50 + 0.40)]
        [Theory]
        public void PriceShouldBeCorrect(bool ketchup, bool mustard, bool pickle, bool mayo, bool bbq, bool onion, bool tomato, bool lettuce, bool amricachees, bool swisscheese, bool bacon, bool mushrooms,decimal price)
        {
            AllosaurusAllAmericanBurger burger =new()
            {
                Ketchup = ketchup,
                Mustard = mustard,
                Pickle = pickle,
                Mayo = mayo,
                BBQ = bbq,
                Onion = onion,
                Tomato = tomato,
                Lettuce = lettuce,
                AmericanCheese = amricachees,
                SwissCheese = swisscheese,
                Bacon = bacon,
                Mushrooms = mushrooms,
            };
            Assert.Equal(price * burger.Patties, burger.Price);    
        }

        /// <summary>
        /// Checks the calories based on the sauce
        /// </summary>
        /// <param name="ketchup">The ketchup to check</param>
        /// <param name="mustard">The mustard to check</param>
        /// <param name="pickle">The pickle to check</param>
        /// <param name="mayo">The mayo to check</param>
        /// <param name="bbq">The bbq to check</param>
        /// <param name="onion">The onion to check</param>
        /// <param name="tomato">The tomato to check</param>
        /// <param name="lettuce">The lettuce to check</param>
        /// <param name="amricachees">The amricachees to check</param>
        /// <param name="swisscheese">The swisscheese to check</param>
        /// <param name="bacon">The bacon to check</param>
        /// <param name="mushrooms">The mushrooms to check</param>
        /// <param name="calories">The expected calories</param>
        [InlineData(true, false, false, false, false, false, false, false, false, false, false, false, 204+19)]
        [InlineData(false, true, false, false, false, false, false, false, false, false, false, false, 204+3)]
        [InlineData(false, false, true, false, false, false, false, false, false, false, false, false, 204+7)]
        [InlineData(false, false, false, true, false, false, false, false, false, false, false, false, 204+94)]
        [InlineData(false, false, false, false, true, false, false, false, false, false, false, false, 204+29)]
        [InlineData(false, false, false, false, false, true, false, false, false, false, false, false, 204+44)]
        [InlineData(false, false, false, false, false, false, true, false, false, false, false, false, 204+22)]
        [InlineData(false, false, false, false, false, false, false, true, false, false, false, false, 204+5)]
        [InlineData(false, false, false, false, false, false, false, false, true, false, false, false, 204+104)]
        [InlineData(false, false, false, false, false, false, false, false, false, true, false, false, 204+106)]
        [InlineData(false, false, false, false, false, false, false, false, false, false, true, false, 204+43)]
        [InlineData(false, false, false, false, false, false, false, false, false, false, false, true, 204+4)]
        [Theory]
        public void CaloriesShouldBeCorrect(bool ketchup, bool mustard, bool pickle, bool mayo, bool bbq, bool onion, bool tomato, bool lettuce, bool amricachees, bool swisscheese, bool bacon, bool mushrooms, uint calories)
        {
            AllosaurusAllAmericanBurger burger =new()
            {
                Ketchup = ketchup,
                Mustard = mustard,
                Pickle = pickle,
                Mayo = mayo,
                BBQ = bbq,
                Onion = onion,
                Tomato = tomato,
                Lettuce = lettuce,
                AmericanCheese = amricachees,
                SwissCheese = swisscheese,
                Bacon = bacon,
                Mushrooms = mushrooms,
            };
            Assert.Equal(calories * burger.Patties, burger.Calories);     
        }


        /// <summary>
        /// Checks the patties
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToOne() 
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.Equal(1u, burger.Patties);
        }

        /// <summary>
        /// Checks that the patties can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties() 
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.Equal(1u, burger.Patties);
        }

        /// <summary>
        /// Checks that the Ketchup should be true
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToTrue()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.True(burger.Ketchup);


        }
        
        /// <summary>
        /// Checks that the ketchup can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup() 
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup); 
            burger.Ketchup = true;
            Assert.True(burger.Ketchup); 

        }

        /// <summary>
        /// Checks that the mustard should be true
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToTrue()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.True(burger.Mustard);

        }

        /// <summary>
        /// Checks that the mustard can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard() 
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);  
            burger.Ketchup = true;
            Assert.True(burger.Ketchup); 
        }

        /// <summary>
        /// Checks that the pickle should be true
        /// </summary>
        [Fact]
        public void PickleShouldDefaultToTrue()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.True(burger.Pickle);
        }

        /// <summary>
        /// Checks that the pickle can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()  
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);  
            burger.Ketchup = true;
            Assert.True(burger.Ketchup); 
        }

        /// <summary>
        /// Checks that the Mayo should be False
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.False(burger.Mayo);
        }

        /// <summary>
        /// Checks that the Mayo can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()  
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);  
            burger.Ketchup = true;
            Assert.True(burger.Ketchup); 
        }

        /// <summary>
        /// Checks that the BBQ should be False
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.False(burger.BBQ);
        }

        /// <summary>
        /// Checks that the BBQ can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ() 
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);    
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);   
        }

        /// <summary>
        /// Checks that the Onion should be False
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.False(burger.Onion);
        }

        /// <summary>
        /// Checks that the Onion can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()    
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);    
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);   
        }

        /// <summary>
        /// Checks that the Tomato should be False
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.False(burger.Tomato);
        }

        /// <summary>
        /// Checks that the Tomato can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()    
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);    
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);   
        }

        /// <summary>
        /// Checks that the Lettuce should be False
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.False(burger.Lettuce);
        }

        /// <summary>
        /// Checks that the Lettuce can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()    
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);    
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);   
        }

        /// <summary>
        /// Checks that the AmericanCheese should be False
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.False(burger.AmericanCheese);
        }

        /// <summary>
        /// Checks that the AmericanCheese can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()    
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);    
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);   
        }

        /// <summary>
        /// Checks that the SwissCheese should be False
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.False(burger.SwissCheese);
        }

        /// <summary>
        /// Checks that the SwissCheese can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()    
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);    
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);   
        }

        /// <summary>
        /// Checks that the Bacon should be False
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.False(burger.Bacon);
        }

        /// <summary>
        /// Checks that the Bacon can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()    
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);    
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);   
        }

        /// <summary>
        /// Checks that the Mushrooms should be False
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger burger =new();
            Assert.False(burger.Mushrooms);
        }

        /// <summary>
        /// Checks that the Mushrooms can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()    
        {
            AllosaurusAllAmericanBurger burger =new();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);    
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);   
        }


        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            AllosaurusAllAmericanBurger burger = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }
        
        /// <summary>
        /// Checks whether the overridden method ToString() returns the expected value.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            AllosaurusAllAmericanBurger burger = new();
            Assert.Equal("Allosaurus All-American Burger", burger.ToString());
        }
    }
}
