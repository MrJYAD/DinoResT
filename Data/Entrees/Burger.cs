/*
* Author: Jyad Aljohani
* File name: Burger.cs
* Purpose: represents all Burgers sold at DinorDiner
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
    /// A base class for all Burgers sold at DinorDiner.
    /// </summary>
    public abstract class Burger : Entree, INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// The numbers of patties
        /// </summary>
        public abstract uint Patties { get; set; }

        /// <summary>
        /// Whether the burger should be served with Ketchup.
        /// </summary>
        public bool _ketchup = true;

        /// <summary>
        /// Whether the burger should be served with Ketchup.
        /// </summary>
        public bool Ketchup
        {
            get => _ketchup;
            set
            {
                if (_ketchup != value)
                {
                    _ketchup = value;
                    OnPropertyChanged(nameof(this.Ketchup));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));

                }
            }
        }


        /// <summary>
        /// Whether the burger should be served with Mustard.
        /// </summary>
        public bool _mustard = true;

        /// <summary>
        /// Whether the burger should be served with Mustard.
        /// </summary>
        public bool Mustard
        {
            get => _mustard;
            set
            {
                if (_mustard != value)
                {
                    _mustard = value;
                    OnPropertyChanged(nameof(this.Mustard));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));


                }
            }
        }
        /// <summary>
        /// Whether the burger should be served with Pickle.
        /// </summary>
        public bool _pickle = true;

        /// <summary>
        /// Whether the burger should be served with Pickle.
        /// </summary>
        public bool Pickle
        {
            get => _pickle;
            set
            {
                if (_pickle != value)
                {
                    _pickle = value;
                    OnPropertyChanged(nameof(this.Pickle));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));


                }
            }
        }

        /// <summary>
        /// Whether the burger should be served with Mayo.
        /// </summary>
        public bool _mayo = true;

        /// <summary>
        /// Whether the burger should be served with Mayo.
        /// </summary>
        public bool Mayo
        {
            get => _mayo;
            set
            {
                if (_mayo != value)
                {
                    _mayo = value;
                    OnPropertyChanged(nameof(this.Mayo));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));


                }
            }
        }
        /// <summary>
        /// Whether the burger should be served with BBQ.
        /// </summary>
        public bool _bbq = true;

        /// <summary>
        /// Whether the burger should be served with BBQ.
        /// </summary>
        public bool BBQ
        {
            get => _bbq;
            set
            {
                if (_bbq != value)
                {
                    _bbq = value;
                    OnPropertyChanged(nameof(this.BBQ));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));


                }
            }
        }
        /// <summary>
        /// Whether the burger should be served with Onion.
        /// </summary>
        public bool _onion = true;

        /// <summary>
        /// Whether the burger should be served with Onion.
        /// </summary>
        public bool Onion
        {
            get => _onion;
            set
            {
                if (_onion != value)
                {
                    _onion = value;
                    OnPropertyChanged(nameof(this.Onion));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));


                }
            }
        }
        /// <summary>
        /// Whether the burger should be served with Tomato.
        /// </summary>
        public bool _tomato = true;

        /// <summary>
        /// Whether the burger should be served with Tomato.
        /// </summary>
        public bool Tomato
        {
            get => _tomato;
            set
            {
                if (_tomato != value)
                {
                    _tomato = value;
                    OnPropertyChanged(nameof(this.Tomato));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));


                }
            }
        }
        /// <summary>
        /// Whether the burger should be served with Lettuce.
        /// </summary>
        public bool _lettuce = true;

        /// <summary>
        /// Whether the burger should be served with Mustard.
        /// </summary>
        public bool Lettuce
        {
            get => _lettuce;
            set
            {
                if (_lettuce != value)
                {
                    _lettuce = value;
                    OnPropertyChanged(nameof(this.Lettuce));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));


                }
            }
        }
        /// <summary>
        /// Whether the burger should be served with AmericanCheese.
        /// </summary>
        public bool _americanCheese = true;

        /// <summary>
        /// Whether the burger should be served with Mustard.
        /// </summary>
        public bool AmericanCheese
        {
            get => _americanCheese;
            set
            {
                if (_americanCheese != value)
                {
                    _americanCheese = value;
                    OnPropertyChanged(nameof(this.AmericanCheese));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));


                }
            }
        }
        /// <summary>
        /// Whether the burger should be served with SwissCheese.
        /// </summary>
        public bool _swissCheese = true;

        /// <summary>
        /// Whether the burger should be served with Mustard.
        /// </summary>
        public bool SwissCheese
        {
            get => _swissCheese;
            set
            {
                if (_swissCheese != value)
                {
                    _swissCheese = value;
                    OnPropertyChanged(nameof(this.SwissCheese));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));


                }
            }
        }
        /// <summary>
        /// Whether the burger should be served with Bacon.
        /// </summary>
        public bool _bacon = true;

        /// <summary>
        /// Whether the burger should be served with Bacon.
        /// </summary>
        public bool Bacon
        {
            get => _bacon;
            set
            {
                if (_bacon != value)
                {
                    _bacon = value;
                    OnPropertyChanged(nameof(this.Bacon));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));

                }
            }
        }
        /// <summary>
        /// Whether the burger should be served with Mushrooms.
        /// </summary>
        public bool _mushrooms = true;

        /// <summary>
        /// Whether the burger should be served with Mushrooms.
        /// </summary>
        public bool Mushrooms
        {
            get => _mushrooms;
            set
            {
                if (_mushrooms != value)
                {
                    _mushrooms = value;
                    OnPropertyChanged(nameof(this.Mushrooms));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Price));


                }
            }
        }
    }
}
