/*
* Author: Jyad Aljohani
* File name: VelociWraptor.cs
* Purpose: represents VelociWraptor
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
    /// A class that represents a Veloci Wraptor
    /// </summary>
    /// <remarks>
    /// The Veloci_Wraptor holds of Wraptor's name, Price, and Calories
    /// and if it has Dressing and Cheese or not.
    /// when Veloci Wraptor order in placed.
    /// </remarks>
    public class VelociWraptor : Entree, INotifyPropertyChanged, IMenuItem
    {


        /// <summary>
        /// The Price of the Veloci Wraptor
        /// </summary>
        public override decimal Price => (decimal)6.25m;

        /// <summary>
        /// The Calories of the Veloci Wraptor
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint defaultCalories = 732u;   
                if (!Dressing)
                {
                    defaultCalories = defaultCalories - 94u;
                }
                if (!Cheese)
                {
                    defaultCalories = defaultCalories - 22u;                  
                } 
                return defaultCalories;
            }
        }

        /// <summary>
        /// The Dressing on the Veloci Wraptor
        /// </summary>
        public bool _dressing = true;

        /// <summary>
        /// The Dressing on the Veloci Wraptor
        /// </summary>
        public bool Dressing
        {
            get => _dressing;
            set
            {
                if (_dressing != value)
                {
                    _dressing = value;
                    OnPropertyChanged(nameof(this.Dressing));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));

                }
            }
        }

        /// <summary>
        /// The Cheese on the Veloci Wraptor
        /// </summary>
        public bool _cheese = true;

        /// <summary>
        /// The Cheese on the Veloci Wraptor
        /// </summary>
        public bool Cheese
        {
            get => _cheese;
            set
            {
                if (_cheese != value)
                {
                    _cheese = value;
                    OnPropertyChanged(nameof(this.Cheese));
                    OnPropertyChanged(nameof(this.Calories));
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
                if (!Dressing) instructions.Add("Hold Dressing");
                if (!Cheese) instructions.Add("Hold Cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            return "Veloci-Wraptor";
        }

        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Wraptor Burger!";
            }
        }
    }
}
