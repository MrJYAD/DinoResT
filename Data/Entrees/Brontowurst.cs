/*
* Author: Jyad Aljohani
* File name: Brontowurst.cs
* Purpose: represents  a Brontowurst
*/
using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class that represents a Brontowurst
    /// </summary>
    /// <remarks>
    /// The Brontowurst holds of Brontowurst's name, Price, and Calories
    /// and if it has Onions and Peppers or not.
    /// when Brontowurst order in placed.
    /// </remarks>
    public class Brontowurst : Entree, INotifyPropertyChanged , IMenuItem
    {


        /// <summary>
        /// The Price of the Brontowurst
        /// </summary>
        public override decimal Price => (decimal) 5.86m;

        /// <summary>
        /// The Calories of the Brontowurst
        /// </summary>
        public override uint Calories => 512u;

        /// <summary>
        /// The Onions on the Brontowurst
        /// </summary>
        public bool _onions = true;

        /// <summary>
        /// The Onions on the Brontowurst
        /// </summary>
        public bool Onions
        {
            get => _onions;
            set
            {
                if (_onions != value)
                {
                    _onions = value;
                    OnPropertyChanged(nameof(this.Onions));
                    OnPropertyChanged(nameof(this.SpecialInstructions));

                }
            }
        }
        /// <summary>
        /// The Peppers on the Brontowurst
        /// </summary>
        public bool _peppers = true;

        /// <summary>
        /// The Peppers on the Brontowurst
        /// </summary>
        public bool Peppers
        {
            get => _peppers;
            set
            {
                if (_peppers != value)
                {
                    _peppers = value;
                    OnPropertyChanged(nameof(this.Peppers));
                    OnPropertyChanged(nameof(this.SpecialInstructions));

                }
            }
        }
        /// <summary>
        /// Special instructions requested by the customer ordering the Burger.
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Onions) instructions.Add("Hold Onions");
                if (!Peppers) instructions.Add("Hold Peppers");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Brontowurst Bruger!";
            }
        }

    }
}
