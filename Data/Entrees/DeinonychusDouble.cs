/*
* Author: Jyad Aljohani
* File name: DeinonychusDouble.cs
* Purpose: represents an entree of DeinonychusDouble
*/
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
    /// A class representing an entree of DeinonychusDouble. 
    /// </summary>
    public class DeinonychusDouble : Burger , INotifyPropertyChanged, IMenuItem
    {

        /// <summary>
        /// Constructs a new DeinonychusDouble.
        /// </summary>
        public DeinonychusDouble()
        {

            Ketchup = false;
            Mustard = false;
            Mayo = false;
            Tomato = false;
            Lettuce = false;
            AmericanCheese = false;
            Bacon = false;


        }

        /// <summary>
        /// the number of patties
        /// </summary>
        public override uint Patties { get; set; } = 2;

        /// <summary>
        /// The Burger's price
        /// </summary>
        public override decimal Price
        {
            get
            {
                decimal price = 1.50m * Patties;
                if (Ketchup) price = price + 0.20m;
                if (Mustard) price = price + 0.20m;
                if (Pickle) price = price + 0.20m;
                if (Mayo) price = price + 0.20m;
                if (BBQ) price = price + 0.10m;
                if (Onion) price = price + 0.40m;
                if (Tomato) price = price + 0.40m;
                if (Lettuce) price = price + 0.30m;
                if (AmericanCheese) price = price + 0.25m;
                if (SwissCheese) price = price + 0.25m;
                if (Bacon) price = price + 0.50m;
                if (Mushrooms) price = price + 0.40m;

                return price;
            }



        }

        /// <summary>
        /// The Burger's Calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 204 * Patties;
                if (Ketchup) calories = calories + 19;
                if (Mustard) calories = calories + 3;
                if (Pickle) calories = calories + 7;
                if (Mayo) calories = calories + 94;
                if (BBQ) calories = calories + 29;
                if (Onion) calories = calories + 44;
                if (Tomato) calories = calories + 22;
                if (Lettuce) calories = calories + 5;
                if (AmericanCheese) calories = calories + 104;
                if (SwissCheese) calories = calories + 106;
                if (Bacon) calories = calories + 43;
                if (Mushrooms) calories = calories + 4;

                return calories;
            }
        }

        /// <summary>
        /// Special instructions requested by the customer ordering the Burger.
        /// </summary>
        public override ICollection<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Patties == 0) instructions.Add("Hold Patties");
                if (Ketchup) instructions.Add("Add Ketchup");
                if (Mustard) instructions.Add("Add Mustard");
                if (!Pickle) instructions.Add("Hold Pickle");
                if (Mayo) instructions.Add("Add Mayo");
                if (!BBQ) instructions.Add("Hold BBQ");
                if (!Onion) instructions.Add("Hold Onion");
                if (Tomato) instructions.Add("Add Tomato");
                if (Lettuce) instructions.Add("Add Lettuce");
                if (AmericanCheese) instructions.Add("Add AmericanCheese");
                if (!SwissCheese) instructions.Add("Hold SwissCheese");
                if (Bacon) instructions.Add("Add Bacon");
                if (!Mushrooms) instructions.Add("Hold Mushrooms");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            return "Deinonychus Double";
        }

        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Double Bruger!";
            }
        }
    }
}
