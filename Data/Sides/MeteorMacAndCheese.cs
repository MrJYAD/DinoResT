/*
* Author: Jyad Aljohani
* File name: MeteorMacNCheese.cs
* Purpose: represents a Meteor Mac and Cheese
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
    /// A class that represents a Meteor Mac and Cheese
    /// </summary>
    /// <remarks>
    /// The planet keeps track of Price, Name, and Calories
    /// in proportion to that of Earth. The values cannot be changed 
    /// after the planet is craeted.
    /// </remarks>
    public class MeteorMacAndCheese : Side, INotifyPropertyChanged, IMenuItem
    {

 
        ///<summary>
        ///The Price of the Meteor Mac and Cheese
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
        ///The Price of the Meteor Mac and Cheese.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 425u;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 510u;
                }
                else
                {
                    return 700u;
                }
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            return $"{Size} Meteor Mac & Cheese";
        }


        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Meteor Mac and Cheese!";
            }
        }
    }
}
