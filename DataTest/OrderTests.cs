using DinoDiner.Data;
using DinoDiner.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace DataTest
{
    public class OrderTests
    {
        /// <summary>
        /// Checks that when an item is added to the Order, 
        /// the item will be included in the order
        /// </summary>
        [Fact]
        public void AddingItemToOrderShouldIncludeItemInOrder()
        {
            var order = new Order();
            var burger = new AllosaurusAllAmericanBurger();
            order.Add(burger);
            Assert.Contains(burger, order);
        }

        /// <summary>
        /// Checks that when an item is remved from the Order, 
        /// the item will be excluded from the order
        /// </summary>
        [Fact]
        public void RemovingItemFromOrderShouldExcludeItemFromOrder()
        {
            var order = new Order();
            var burger = new AllosaurusAllAmericanBurger();
            order.Remove(burger);
            Assert.DoesNotContain(burger, order);
        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        /// <summary>
        /// Checks whether INotifyCollectionChanged  can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyCollectionChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
        }

        /// <summary>
        /// Checks notification of the property "Total" when an item is added.
        /// </summary>
        [Fact]
        void AddingItemNotifiesTotal()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(new AllosaurusAllAmericanBurger());
            });
        }

        /// <summary>
        /// Checks notification of the property "Subtotal" when an item is added.
        /// </summary>
        [Fact]
        void AddingItemNotifiesSubtotal()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(new AllosaurusAllAmericanBurger());
            });
        }

        /// <summary>
        /// Checks notification of the property "Tax" when an item is added.
        /// </summary>
        [Fact]
        void AddingItemNotifiesTax()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(new AllosaurusAllAmericanBurger());
            });
        }

        /// <summary>
        /// Checks notification of the property "Calories" when an item is added.
        /// </summary>
        [Fact]
        void AddingItemNotifiesCalories()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(new AllosaurusAllAmericanBurger());
            });
        }

        /// <summary>
        /// Checks notification of the property "Total" when an item is removed.
        /// </summary>
        [Fact]
        void RemovingItemNotifiesTotal()
        {
            var order = new Order();
            var burger = new AllosaurusAllAmericanBurger();
            order.Add(burger);
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Remove(burger);
            });
        }

        /// <summary>
        /// Checks notification of the property "Subtotal" when an item is removed.
        /// </summary>
        [Fact]
        void RemovingItemNotifiesSubtotal()
        {
            var order = new Order();
            var burger = new AllosaurusAllAmericanBurger();
            order.Add(burger);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(burger);
            });
        }

        /// <summary>
        /// Checks notification of the property "Tax" when an item is removed.
        /// </summary>
        [Fact]
        void RemovingItemNotifiesTax()
        {
            var order = new Order();
            var burger = new AllosaurusAllAmericanBurger();
            order.Add(burger);
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(burger);
            });
        }

        /// <summary>
        /// Checks notification of the property "Calories" when an item is removed.
        /// </summary>
        [Fact]
        void RemovingItemNotifiesCalories()
        {
            var order = new Order();
            var burger = new AllosaurusAllAmericanBurger();
            order.Add(burger);
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(burger);
            });
        }
    }
}

