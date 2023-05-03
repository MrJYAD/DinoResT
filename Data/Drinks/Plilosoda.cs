/*
* Author: Jyad Aljohani
* File name: Plilosoda.cs
* Purpose: represents Plilosoda
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
namespace DinoDiner.Data.Drinks
{

    /// <summary>
    /// A class representing a soda.
    /// </summary>
    public class Plilosoda : Drink , INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// The flavor of Plilosoda.
        /// </summary>
        public SodaFlavor _flavor = SodaFlavor.Cola;

        /// <summary>
        /// The flavor of this Plilosoda.
        /// </summary>
        public SodaFlavor Flavor
        {
            get => _flavor;
            set
            {
                if (_flavor != value)
                {
                    _flavor = value;
                    OnPropertyChanged(nameof(this.Flavor));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.Name));
                }
            }
        }
        /// <summary>
        /// The size of Plilosoda.
        /// </summary>
        public ServingSize _size = ServingSize.Small;

        /// <summary>
        /// The size of this Plilosoda.
        /// </summary>
        public ServingSize Size
        {
            get => _size;
            set
            {
                if (_size != value)
                {
                    _size = value;
                    OnPropertyChanged(nameof(this.Size));
                    OnPropertyChanged(nameof(this.Name));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.Price));

                }
            }
        }

        /// <summary>
        /// The spacing between flavor names.
        /// </summary>
        private string SpaceFlavor
        {
            get
            {
                if (Flavor == SodaFlavor.CherryCola) return $"Cherry Cola";
                if (Flavor == SodaFlavor.DoctorDino) return $"Doctor Dino";
                if (Flavor == SodaFlavor.LemonLime) return $"Lemon-Lime";
                if (Flavor == SodaFlavor.DinoDew) return $"Dino Dew";
                else return $"Cola";
            }
        }

   

        /// <summary>
        /// The Price of the Plilosoda.
        /// </summary>
        public override decimal Price 
        {
            get
            {
                if (Size == ServingSize.Small) return 1.00m;
                else if (Size == ServingSize.Medium) return 1.75m;
                return 2.50m;
            }
        }

        /// <summary>
        /// The calories of the Plilosoda.
        /// </summary>
        public override uint Calories 
        {
            get
            {
                if (Size == ServingSize.Small && Flavor == SodaFlavor.Cola ) return 180u;
                if (Size == ServingSize.Small && Flavor == SodaFlavor.CherryCola) return 100u;
                if (Size == ServingSize.Small && Flavor == SodaFlavor.DoctorDino) return 120u;
                if (Size == ServingSize.Small && Flavor == SodaFlavor.LemonLime) return 41u;
                if (Size == ServingSize.Small && Flavor == SodaFlavor.DinoDew) return 141u;

                else if (Size == ServingSize.Medium && Flavor == SodaFlavor.Cola) return 288u;
                else if (Size == ServingSize.Medium && Flavor == SodaFlavor.CherryCola) return 160u;
                else if(Size == ServingSize.Medium && Flavor == SodaFlavor.DoctorDino) return 192u;
                else if (Size == ServingSize.Medium && Flavor == SodaFlavor.LemonLime) return 66u;
                else if (Size == ServingSize.Medium && Flavor == SodaFlavor.DinoDew) return 256u;

                else if (Size == ServingSize.Large && Flavor == SodaFlavor.Cola) return 432u;
                else if (Size == ServingSize.Large && Flavor == SodaFlavor.CherryCola) return 240u;
                else if (Size == ServingSize.Large && Flavor == SodaFlavor.DoctorDino) return 288u;
                else if (Size == ServingSize.Large && Flavor == SodaFlavor.LemonLime) return 98u;
                return 338u;
            }
        }

        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns> A readable name of the order</returns>
        public override string ToString()
        {
            if (Size == ServingSize.Small) return $"Small {SpaceFlavor} Plilosoda";
            else if (Size == ServingSize.Medium) return $"Medium {SpaceFlavor} Plilosoda";
            return $"Large {SpaceFlavor} Plilosoda";
        }

        /// <summary>
        /// The description of the coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Plilsoda Drink!";
            }
        }
    }
}
