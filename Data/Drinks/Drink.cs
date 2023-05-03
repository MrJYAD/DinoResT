/*
* Author: Jyad Aljohani
* File name: Drink.cs
* Purpose: represents base class for all drinks at Dino diner
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// A base class for all drinks at Dino diner .
    /// </summary>
    public abstract class Drink : INotifyPropertyChanged, IMenuItem
    {

        /// <summary>
        /// Notifies when a property of this class changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The name of the Entree
        /// </summary>
        public string Name { get => ToString(); }

        /// <summary>
        /// The price of the Entree
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the Entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions for preparing the drink.
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// The description of the drink.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        public string Type { get => "Drink"; }

        /// <summary>
        /// Used to trigger a PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The name of the property that is changing</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
