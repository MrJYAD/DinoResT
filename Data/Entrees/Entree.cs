/*
* Author: Jyad Aljohani
* File name: Entree.cs
* Purpose: A base class for all entrees sold at DinoDiner
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A base class for all entrees sold at DinoDiner
    /// </summary>
    public abstract class Entree : INotifyPropertyChanged, IMenuItem
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
        /// Special instructions requested by the customer ordering the entree.
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// The description of the drink.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        public string Type { get => "Entree"; }

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
