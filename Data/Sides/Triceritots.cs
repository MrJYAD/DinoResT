/*
* Author: Jyad Aljohani
* File name: Triceritots.cs
* Purpose: represents a represents a Triceritots
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{

    /// <summary>
    /// A class that represents a Triceritots
    /// </summary>
    /// <remarks>
    /// The Brontowurst keeps track of Triceritots's name, Size, Calories and Price
    /// when Triceritots order in placed.
    /// </remarks>
    public class Triceritots : Side, INotifyPropertyChanged, IMenuItem
    {

        ///<summary>
        /// The Price of the Triceritots.
        ///</summary>
        public override decimal Price
        {
            get{
                if (Size == ServingSize.Small) { return (decimal)3.50; }
                else if (Size == ServingSize.Medium) { return (decimal)4.00; }
                else {return (decimal)5.25;}
            }

        }

        /// <summary>
        /// The Calories of the Triceritots
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 351u;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 409u;
                }
                else
                {
                    return 583u;
                }
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            return $"{Size} Triceritots";
        }

        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Triceritots!";
            }
        }

    }
}
