/*
* Author: Jyad Aljohani
* File name: CretaceousCoffee.cs
* Purpose: represents an entree of CretaceousCoffee
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.ComponentModel;


namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// A class representing an entree of CretaceousCoffee.
    /// </summary>
    public class CrustaceousCoffee : Drink, INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// The size of the coffee
        /// </summary>
        public ServingSize _size;

        /// <summary>
        /// The size of the coffee
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
                    OnPropertyChanged(nameof(this.Name));
                    OnPropertyChanged(nameof(this.Price));
                    OnPropertyChanged(nameof(this.SpecialInstructions));


                }
            }
        }


        /// <summary>
        /// The price of the coffee.
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Small) return 0.75m;
                else if (Size == ServingSize.Medium) return 1.25m;
                return 2.00m;
            }
        }

        /// <summary>
        /// The Calories of the coffee.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Cream) return 64u;
                else return 0u;

            }

        }

        /// <summary>
        /// Whether the coffee is sweetened with cream.
        /// </summary>
        public bool _cream = false;

        /// <summary>
        /// The coffee doesn't have cream by default
        /// </summary>
        public bool Cream
        {
            get => _cream;
            set
            {
                if (_cream != value)
                {
                    _cream = value;
                    OnPropertyChanged(nameof(this.Cream));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Special instructions requested by the customer ordering the Burger.
        /// </summary>
        public IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Cream) instructions.Add("Add Cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            return $"{Size} Coffee";
        }
        
        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Good Coffee!";
            }
        }
    }
}
