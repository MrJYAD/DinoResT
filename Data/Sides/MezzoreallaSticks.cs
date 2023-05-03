/*
* Author: Jyad Aljohani
* File name: MezzoreallaSticks.cs
* Purpose: represents a represents Mezzorella Sticks
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
    /// A class that represents Mezzorella Sticks
    /// </summary>
    /// <remarks>
    /// The MezzorellaSticks keeps track of Mezzorella Sticks's name, Price, Size and Calories
    /// when Mezzorella Sticks order in placed.
    /// </remarks>
    public class MezzoreallaSticks : Side, INotifyPropertyChanged, IMenuItem
    {

   

        ///<summary>
        /// The Price of the Mezzorella Sticks.
        ///</summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Small) return 3.50m;
                else if (Size == ServingSize.Medium) return 4.00m;
                else return 5.25m;
            }
        }

        /// <summary>
        /// The Calories of the Mezzorella Sticks
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 530u;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 620u;
                }
                else
                {
                    return 730u;
                }
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            return $"{Size} Mezzorella Sticks";
        }

        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Mezzorella Sticks!";
            }
        }
    }
}
