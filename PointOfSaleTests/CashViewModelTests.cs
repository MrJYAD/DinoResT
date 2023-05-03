/*
* Author: Jyad Aljohani
* File name: CashViewModelTests.cs
* Purpose: To unit test the CashViewModel class
*/
using System;
using Xunit;
using System.ComponentModel;
using DinoDiner.Data.Entrees;
using DinoDiner.Data;
using DinoDiner.PointOfSale;

namespace PointOfSaleTests
{
    /// <summary>
    /// Unit tests for CashViewMode class.
    /// </summary>
    public class CashViewModelTests
    {
        /// <summary>
        /// Checking that amount due changes as the cashier receives money.
        /// </summary>
        [Fact]
        public void AmountDueShouldChangeAsTheCashierReceivesMoney()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingTens = 1;
            Assert.Equal(2, (double)cashViewModel.OutgoingOnes);
            Assert.Equal(0, (double)cashViewModel.OutgoingHundreds);
            Assert.Equal(0, (double)cashViewModel.OutgoingFifties);
            Assert.Equal(0, (double)cashViewModel.OutgoingTwenties);
            Assert.Equal(0, (double)cashViewModel.OutgoingTens);
            Assert.Equal(1, (double)cashViewModel.OutgoingFives);
            Assert.Equal(0, (double)cashViewModel.OutgoingTwos);
            Assert.Equal(0, (double)cashViewModel.OutgoingDollars);
            Assert.Equal(0, (double)cashViewModel.OutgoingHalfDollars);
            Assert.Equal(2, (double)cashViewModel.OutgoingQuarters);
            Assert.Equal(2, (double)cashViewModel.OutgoingDimes);
            Assert.Equal(0, (double)cashViewModel.OutgoingNickels);
            Assert.Equal(1, (double)cashViewModel.OutgoingPennies);
        }

        /// <summary>
        /// Checking that change owed changes as the cashier receives money.
        /// </summary>
        [Fact]
        public void ChangeOwedShouldChangeAsTheCashierReceivesMoney()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingTwenties = 1;
            Assert.Equal(2, (double)cashViewModel.OutgoingOnes);
            Assert.Equal(0, (double)cashViewModel.OutgoingHundreds);
            Assert.Equal(0, (double)cashViewModel.OutgoingFifties);
            Assert.Equal(0, (double)cashViewModel.OutgoingTwenties);
            Assert.Equal(1, (double)cashViewModel.OutgoingTens);
            Assert.Equal(1, (double)cashViewModel.OutgoingFives);
            Assert.Equal(0, (double)cashViewModel.OutgoingTwos);
            Assert.Equal(0, (double)cashViewModel.OutgoingDollars);
            Assert.Equal(0, (double)cashViewModel.OutgoingHalfDollars);
            Assert.Equal(2, (double)cashViewModel.OutgoingQuarters);
            Assert.Equal(2, (double)cashViewModel.OutgoingDimes);
            Assert.Equal(0, (double)cashViewModel.OutgoingNickels);
            Assert.Equal(1, (double)cashViewModel.OutgoingPennies);
        }

        /// <summary>
        /// Checks that IncomingHundreds can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingHundreds()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewMode = new CashViewModel(order);
            cashViewMode.IncomingHundreds = 1;
            Assert.Equal(1, (double)cashViewMode.IncomingHundreds);
            Assert.Equal(0, (double)cashViewMode.IncomingFifties);
            Assert.Equal(0, (double)cashViewMode.IncomingTwenties);
            Assert.Equal(0, (double)cashViewMode.IncomingTens);
            Assert.Equal(0, (double)cashViewMode.IncomingFives);
            Assert.Equal(0, (double)cashViewMode.IncomingTwos);
            Assert.Equal(0, (double)cashViewMode.IncomingOnes);
            Assert.Equal(0, (double)cashViewMode.IncomingDollars);
            Assert.Equal(0, (double)cashViewMode.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewMode.IncomingQuarters);
            Assert.Equal(0, (double)cashViewMode.IncomingDimes);
            Assert.Equal(0, (double)cashViewMode.IncomingNickels);
            Assert.Equal(0, (double)cashViewMode.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingHundreds can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingFifties()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingFifties = 2;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(2, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingTwenties can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingTwenties()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingTwenties = 3;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(3, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingTens can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingTens()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingTens = 1;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(1, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingFives can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingFives()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingFives = 1;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(1, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingTwos can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingTwos()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingTwos = 1;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(1, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingOnes can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingOnes()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingOnes = 5;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(5, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingDollars can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingDollars()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingDollars = 4;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(4, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingHalfDollars can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingHalfDollars()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingHalfDollars = 8;
             Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(8, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingQuarters can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingQuarters()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingQuarters = 3;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(3, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingDimes can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingDimes()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingDimes = 2;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(2, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingNickels can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingNickels()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingNickels = 4;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(4, (double)cashViewModel.IncomingNickels);
            Assert.Equal(0, (double)cashViewModel.IncomingPennies);
        }

        /// <summary>
        /// Checks that IncomingNickels can be set.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIncomingPennies()
        {
            var order = new Order();
            order.Add(new AllosaurusAllAmericanBurger());
            var cashViewModel = new CashViewModel(order);
            cashViewModel.IncomingPennies = 9;
            Assert.Equal(0, (double)cashViewModel.IncomingHundreds);
            Assert.Equal(0, (double)cashViewModel.IncomingFifties);
            Assert.Equal(0, (double)cashViewModel.IncomingTwenties);
            Assert.Equal(0, (double)cashViewModel.IncomingTens);
            Assert.Equal(0, (double)cashViewModel.IncomingFives);
            Assert.Equal(0, (double)cashViewModel.IncomingTwos);
            Assert.Equal(0, (double)cashViewModel.IncomingOnes);
            Assert.Equal(0, (double)cashViewModel.IncomingDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingHalfDollars);
            Assert.Equal(0, (double)cashViewModel.IncomingQuarters);
            Assert.Equal(0, (double)cashViewModel.IncomingDimes);
            Assert.Equal(0, (double)cashViewModel.IncomingNickels);
            Assert.Equal(9, (double)cashViewModel.IncomingPennies);
        }
    }
}
