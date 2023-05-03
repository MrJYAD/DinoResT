/*
* Author: Jyad Aljohani
* File name: PterodactylWings.cs
* Purpose: represents a Pterodacty lWings
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class that represents Pteridactyl Wings
    /// </summary>
    /// <remarks>
    /// The PterodactylWings holds of Pterodacty lWings's name, Price and Calories
    /// and if it has Sauce or not.
    /// when Pteridactyl Wings order in placed.
    /// </remarks>
    public class PterodactylWings : Entree, INotifyPropertyChanged, IMenuItem
    {
    

        /// <summary>
        /// The Sauce on the Pteridactyl Wings
        /// </summary>
        public WingSauce _sauce = WingSauce.Buffalo;

        /// <summary>
        /// The Sauce on the Pteridactyl Wings
        /// </summary>
        public WingSauce Sauce
        {
            get => _sauce;
            set
            {
                if (_sauce != value)
                {
                    _sauce = value;
                    OnPropertyChanged(nameof(this.Sauce));
                    OnPropertyChanged(nameof(this.Name));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));


                }
            }
        }


        /// <summary>
        /// The Price of the Pteridactyl Wings
        /// </summary>
        public override decimal Price
        {
            get 
            {
             return 8.95m;
            }
        }

        /// <summary>
        /// The Calories of the Pteridactyl Wings
        /// </summary>
        public override uint Calories { 
            get 
            {
                if (Sauce == WingSauce.Buffalo)
                {
                    return 360u; 
                }
                else if (Sauce == WingSauce.Teriyaki)
                {
                    return 342u;
                }
                else{
                    return 359u;
                }
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
                if (Sauce == WingSauce.Buffalo) instructions.Add("Use Buffalo");
                if (Sauce == WingSauce.Teriyaki) instructions.Add("Use Teriyaki");
                if (Sauce == WingSauce.HoneyGlaze) instructions.Add("Use Honey Glaze");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            if (Sauce == WingSauce.HoneyGlaze) return "Honey Glaze Pterodactyl Wings";
            return $"{Sauce} Pterodactyl Wings";
        }


        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Pterodactyl Wings!";
            }
        }

    }
}
