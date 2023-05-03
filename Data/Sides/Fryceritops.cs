
/*
* Author: Jyad Aljohani
* File name: Fryceritops.cs
* Purpose: represents a represents Fryceritops
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.ComponentModel;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class that represents Fryceritops
    /// </summary>
    /// <remarks>
    /// The Fryceritops holds of Fryceritops's name , Salt, Sauce, Size, Price and Calories
    /// and if it has Salt and Sauce or not.
    /// when Fryceritops order in placed.
    /// </remarks>
    public class Fryceritops: Side, INotifyPropertyChanged ,IMenuItem
    {


        /// <summary>
        /// The Salt on the Fryceritops
        /// </summary>        
        public bool _salt = true;

        /// <summary>
        /// The Salt on the Fryceritops
        /// </summary>
        public bool Salt
        {
            get => _salt;
            set
            {
                if (_salt != value)
                {
                    _salt = value;
                    OnPropertyChanged(nameof(this.Salt));
                    OnPropertyChanged(nameof(this.SpecialInstructions));


                }
            }
        }
        /// <summary>
        /// The Sauce on the Fryceritops
        /// </summary>        
        public bool _sauce = false;

        /// <summary>
        /// The Sauce on the Fryceritops
        /// </summary>
        public bool Sauce
        {
            get => _sauce;
            set
            {
                if (_sauce != value)
                {
                    _sauce = value;
                    OnPropertyChanged(nameof(this.Sauce));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));

                }
            }
        }
        /// <summary>
        /// The Price of the Fryceritops
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Small) return 3.50m;
                else if (Size == ServingSize.Medium) return 4.00m;
                else return 5.00m;
            }

        }

        /// <summary>
        /// The Calories of the Fryceritops
        /// </summary>
        public override uint Calories
        {
            get
            {
                 uint sauceCals = 0u;
                if (Sauce) sauceCals = sauceCals + 80u;
                if (Size == ServingSize.Small) sauceCals = sauceCals + 365u;
                else if (Size == ServingSize.Medium) sauceCals = sauceCals + 456u;
                else if (Size == ServingSize.Large) sauceCals = sauceCals + 510u;
                return sauceCals;
            }
        }

        /// <summary>
        /// Special instructions requested by the customer ordering the PBJ.
        /// </summary>
        public ICollection<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Sauce) instructions.Add("Add Sauce");
                if (!Salt) instructions.Add("Hold Salt");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            return $"{Size} Fryceritops";
        }

        /// <summary>
        /// The description of the Fryceritops.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Fryceritops";
            }
        }
    }
}
