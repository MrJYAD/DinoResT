/*
* Author: Jyad Aljohani
* File name: IMenuItem.cs
* Purpose: An interface that implements menu items.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace DinoDiner.Data
{
    /// <summary>
    ///  An interface that implements menu items.
    /// </summary>
    public interface IMenuItem : INotifyPropertyChanged
    {

        /// <summary>
        /// The price of the menu item.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// The calories of the menu item.
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// The special instructions for preparing the menu item.
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// The name of the menu item.
        /// </summary>
        public string Name { get => ToString(); }

        /// <summary>
        /// The description of the menu item.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        public string Type { get; }
    }
}
