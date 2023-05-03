/*
* Author: Jyad Aljohani
* File name: Order.cs
* Purpose: Represents an order at DinoDiner.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace DinoDiner.Data
{

    /// <summary>
    /// A class that represents an order at DinoDiner.
    /// </summary>
    public class Order : ObservableCollection<IMenuItem>
    {

        /// <summary>
        /// Constructs a new order.
        /// </summary>
        public Order()
        {
            Number = _nextOrderNumber;
            _nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
        }

        /// <summary>
        /// The next order number.
        /// </summary>
        private static uint _nextOrderNumber = 1;

        /// <summary>
        /// The sales tax rate of the order.
        /// </summary>
        public decimal _salesTaxRate = (decimal)0.09;

        /// <summary>
        /// The sales tax rate of the order.
        /// </summary>
        public decimal SalesTaxRate
        {
            get => _salesTaxRate;
            set
            {
                if (_salesTaxRate != value)
                {
                    _salesTaxRate = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("SalesTaxRate"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                }
            }
        }

        /// <summary>
        /// The subtotal of the order.
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                decimal subtotal = 0;
                foreach (IMenuItem item in this)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// The tax of the order.
        /// </summary>
        public decimal Tax { get => Subtotal * SalesTaxRate; }

        /// <summary>
        /// The total of the order.
        /// </summary>
        public decimal Total { get => Subtotal + Tax; }

        /// <summary>
        /// The calories of the order.
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach (IMenuItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        /// <summary>
        /// The order number.
        /// </summary>
        public uint Number { get; }

        /// <summary>
        /// The date and time the order was placed at.
        /// </summary>
        private DateTime _placedAt = DateTime.Now;

        /// <summary>
        /// The date and time the order was placed at.
        /// </summary>
        public DateTime PlacedAt { get => _placedAt; }

        /// <summary>
        /// Event listener that responds to changes in the collection.
        /// </summary>
        /// <param name="sender">The control that sent the event</param>
        /// <param name="e">The event args</param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IMenuItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListner;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IMenuItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListner;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }

        /// <summary>
        /// Event listener that responds to changes of the items in the collection.
        /// </summary>
        /// <param name="sender">The control that sent the event</param>
        /// <param name="e">The event args</param>
        void CollectionItemChangedListner(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            }
            if (e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
