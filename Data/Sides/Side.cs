/*
* Author: Jyad Aljohani
* File name: Side.cs
* Purpose: represents a  base class for all sides sold at Dinor Diner
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A base class for all sides sold at Dinor Diner.
    /// </summary>
    public abstract class Side: INotifyPropertyChanged, IMenuItem
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
        /// The size of the side.
        /// </summary>
        public ServingSize _size = ServingSize.Small;
       
        /// <summary>
        /// The size of the side.
        /// </summary>
        public ServingSize Size
        {
            get => _size;
            set
            {
                if (_size != value)
                {
                    _size = value;
                    OnPropertyChanged(nameof(this.Size));
                    OnPropertyChanged(nameof(this.Price));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Name));


                }
            }
        }

        /// <summary>
        /// The price of the Entree
        /// </summary>
        public abstract decimal Price { get; }


        /// <summary>
        /// The calories of the Entree
        /// </summary>
        public abstract uint Calories { get; }
        
        /// <summary>
        /// The special instructions for preparing the side.
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// The description of the drink.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        public string Type { get => "Side"; }

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
