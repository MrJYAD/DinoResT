/*
* Author: Jyad Aljohani
* File name: PrehistoricPBJ.cs
* Purpose: represents PrehistoricPBJ
*/
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a Prehistoric PBJ sandwich
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged , IMenuItem
    {
        /// <summary>
        /// Indicates if the PBJ was made with peanut butter
        /// </summary>
        public bool _peanutButter = true;

        /// <summary>
        /// Indicates if the PBJ was made with peanut butter
        /// </summary>
        public bool PeanutButter
        {
            get => _peanutButter;
            set
            {
                if (_peanutButter != value)
                {
                    _peanutButter = value;
                    OnPropertyChanged(nameof(this.PeanutButter));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));

                }
            }
        }
        /// <summary>
        /// Indicates the PBJ was made with jelly
        /// </summary>
        public bool _jelly = true;

        /// <summary>
        /// Indicates the PBJ was made with jelly
        /// </summary>
        public bool Jelly
        {
            get => _jelly;
            set
            {
                if (_jelly != value)
                {
                    _jelly = value;
                    OnPropertyChanged(nameof(this.Jelly));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));

                }
            }
        }
        /// <summary>
        /// Indicates the PBJ is served toasted
        /// </summary>
        /// <summary>
        /// Indicates the PBJ was made with jelly
        /// </summary>
        public bool _toasted = true;

        /// <summary>
        /// Indicates the PBJ was made with jelly
        /// </summary>
        public bool Toasted
        {
            get => _toasted;
            set
            {
                if (_toasted != value)
                {
                    _toasted = value;
                    OnPropertyChanged(nameof(this.Toasted));
                    OnPropertyChanged(nameof(this.SpecialInstructions));

                }
            }
        }
        /// <summary>
        /// The price of the PBJ
        /// </summary>
        public override decimal Price { get; } = 3.75m;



        /// <summary>
        /// The calories of the PBJ
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 148;
                if (PeanutButter) calories += 188;
                if (Jelly) calories += 62;
                return calories;
            }
        }


        /// <summary>
        /// Special instructions requested by the customer ordering the PBJ.
        /// </summary>
        public override ICollection<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!PeanutButter) instructions.Add("Hold Peanut Butter");
                if (!Jelly) instructions.Add("Hold Jelly");
                if (!Toasted) instructions.Add("Not Toasted");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            return "Prehistoric PBJ";
        }

        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Prehistoric PBJ!";
            }
        }
    }
}