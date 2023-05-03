/*
* Author: Jyad Aljohani
* File name: DinoNuggets.cs
* Purpose: class that represents Dino Nuggets
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class that represents Dino Nuggets
    /// </summary>
    /// <remarks>
    /// The DinoNuggets holds of DinoNuggets's name, Count, Price, and Calories
    /// when Dino Nuggets order in placed.
    /// </remarks>
    public class DinoNuggets : Entree, INotifyPropertyChanged , IMenuItem
    {
        
    

        /// <summary>
        /// The Count of the Dino Nuggets
        /// </summary>
        public  uint Count { get; set; } = 6;

        /// <summary>
       /// The Price of the Dino Nugget
       /// </summary>
        public override decimal Price
        {
            get
            {
                return Count * 0.25m;
            }
        }

        /// <summary>
        /// The Calories of the Dino Nuggets
        /// </summary>
        public override uint Calories => 61 * Count;

        /// <summary>
        /// Special instructions requested by the customer ordering the Dino Nuggets.
        /// </summary>
        public override ICollection<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
              
                return instructions;
            }
        }


        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            return $"{Count} Dino Nuggets";
        }

        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Chicken Nuggets!";
            }
        }
    }
}
