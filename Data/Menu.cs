/*
* Author: Jyad Aljohani
* File name: Menu.cs
* Purpose: Represents the Menu at Dino Diner.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Drinks;
using System.Drawing;

namespace DinoDiner.Data
{
    public static class Menu
    {
        /// <summary>
        /// Gets all available Entrees on the Menu.
        /// </summary>
        public static IEnumerable<IMenuItem> Entrees
        {
            get
            {
                var all = new AllosaurusAllAmericanBurger();
                var bro = new Brontowurst();
                var carcheese = new CarnotaurusCheeseburger();
                var doubleDeino = new DeinonychusDouble();
                var dino = new DinoNuggets();
                var pre = new PrehistoricPBJ();
                var wings = new PterodactylWings();
                var trex = new TRexTriple();
                var wraptor = new VelociWraptor();
                List<IMenuItem> entrees = new List<IMenuItem>();
                entrees.Add(all);
                entrees.Add(bro);
                entrees.Add(carcheese);
                entrees.Add(doubleDeino);
                entrees.Add(dino);
                entrees.Add(pre);
                entrees.Add(wings);
                entrees.Add(trex);
                entrees.Add(wraptor);
                return entrees; 
            }
        }

        /// <summary>
        /// Gets all available Sides on the Menu.
        /// </summary>
        public static IEnumerable<IMenuItem> Sides
        {
            get
            {
                var smallfry = new Fryceritops() { Size = ServingSize.Small };
                var mediumfry = new Fryceritops() { Size = ServingSize.Medium };
                var largefry = new Fryceritops() { Size = ServingSize.Large };

                var smallmnc = new MeteorMacAndCheese() { Size = ServingSize.Small };
                var mediummnc = new MeteorMacAndCheese() { Size = ServingSize.Medium };
                var largemnc = new MeteorMacAndCheese() { Size = ServingSize.Large };

                var smallms = new MezzoreallaSticks() { Size = ServingSize.Small };
                var mediumms = new MezzoreallaSticks() { Size = ServingSize.Medium };
                var largems = new MezzoreallaSticks() { Size = ServingSize.Large };
                var smalltri = new Triceritots() { Size = ServingSize.Small };
                var mediumtri = new Triceritots() { Size = ServingSize.Medium };
                var largetri = new Triceritots() { Size = ServingSize.Large };

                List<IMenuItem> sides = new List<IMenuItem>();
                sides.Add(smallfry);
                sides.Add(mediumfry);
                sides.Add(largefry);
                sides.Add(smallmnc);
                sides.Add(mediummnc);
                sides.Add(largemnc);
                sides.Add(smallms);
                sides.Add(mediumms);
                sides.Add(largems);
                sides.Add(smalltri);
                sides.Add(mediumtri);
                sides.Add(largetri);
                return sides;
            }
        }

        /// <summary>
        /// Gets all available Drinks on the Menu.
        /// </summary>
        public static IEnumerable<IMenuItem> Drinks
        {
            get
            {
                var smallcoffe = new CrustaceousCoffee() { Size = ServingSize.Small };
                var medcoffe = new CrustaceousCoffee() { Size = ServingSize.Medium };
                var largecoffe = new CrustaceousCoffee() { Size = ServingSize.Large };

                var smallcola = new Plilosoda() { Size = ServingSize.Small, Flavor = SodaFlavor.Cola };
                var smallcherrycola = new Plilosoda() { Size = ServingSize.Small, Flavor = SodaFlavor.CherryCola };
                var smallDoctorDino  = new Plilosoda() { Size = ServingSize.Small, Flavor = SodaFlavor.DoctorDino };
                var smallLemonLime = new Plilosoda() { Size = ServingSize.Small, Flavor = SodaFlavor.LemonLime };
                var smallDinoDew = new Plilosoda() { Size = ServingSize.Small, Flavor = SodaFlavor.DinoDew };

                var mediumcola = new Plilosoda() { Size = ServingSize.Medium, Flavor = SodaFlavor.Cola };
                var mediumcherrycola = new Plilosoda() { Size = ServingSize.Medium, Flavor = SodaFlavor.CherryCola };
                var mediumDoctorDino = new Plilosoda() { Size = ServingSize.Medium, Flavor = SodaFlavor.DoctorDino };
                var mediumLemonLime = new Plilosoda() { Size = ServingSize.Medium, Flavor = SodaFlavor.LemonLime };
                var mediumlDinoDew = new Plilosoda() { Size = ServingSize.Medium, Flavor = SodaFlavor.DinoDew };

                var largecola = new Plilosoda() { Size = ServingSize.Large, Flavor = SodaFlavor.Cola };
                var largecherrycola = new Plilosoda() { Size = ServingSize.Large, Flavor = SodaFlavor.CherryCola };
                var largeDoctorDino = new Plilosoda() { Size = ServingSize.Large, Flavor = SodaFlavor.DoctorDino };
                var largeLemonLime = new Plilosoda() { Size = ServingSize.Large, Flavor = SodaFlavor.LemonLime };
                var largeDinoDew = new Plilosoda() { Size = ServingSize.Large, Flavor = SodaFlavor.DinoDew };

                List<IMenuItem> drinks = new List<IMenuItem>();
                drinks.Add(smallcoffe);
                drinks.Add(medcoffe);
                drinks.Add(largecoffe);

                drinks.Add(smallcola);
                drinks.Add(smallcherrycola);
                drinks.Add(smallDoctorDino);
                drinks.Add(smallLemonLime);
                drinks.Add(smallDinoDew);

                drinks.Add(mediumcola);
                drinks.Add(mediumcherrycola);
                drinks.Add(mediumDoctorDino);
                drinks.Add(mediumLemonLime);
                drinks.Add(mediumlDinoDew);

                drinks.Add(largecola);
                drinks.Add(largecherrycola);
                drinks.Add(largeDoctorDino);
                drinks.Add(largeLemonLime);
                drinks.Add(largeDinoDew);

                return drinks;
            }
        }

        /// <summary>
        /// Gets all available items on the Menu.
        /// </summary>
        public static IEnumerable<IMenuItem> FullMenu
        {
            get
            {
                List<IMenuItem> fullMenu = new List<IMenuItem>();
                var all = new AllosaurusAllAmericanBurger();
                var bro = new Brontowurst();
                var carcheese = new CarnotaurusCheeseburger();
                var doubleDeino = new DeinonychusDouble();
                var dino = new DinoNuggets();
                var pre = new PrehistoricPBJ();
                var wings = new PterodactylWings();
                var trex = new TRexTriple();
                var wraptor = new VelociWraptor();

                var smallfry = new Fryceritops() { Size = ServingSize.Small };
                var mediumfry = new Fryceritops() { Size = ServingSize.Medium };
                var largefry = new Fryceritops() { Size = ServingSize.Large };
                var smallmnc = new MeteorMacAndCheese() { Size = ServingSize.Small };
                var mediummnc = new MeteorMacAndCheese() { Size = ServingSize.Medium };
                var largemnc = new MeteorMacAndCheese() { Size = ServingSize.Large };
                var smallms = new MezzoreallaSticks() { Size = ServingSize.Small };
                var mediumms = new MezzoreallaSticks() { Size = ServingSize.Medium };
                var largems = new MezzoreallaSticks() { Size = ServingSize.Large };
                var smalltri = new Triceritots() { Size = ServingSize.Small };
                var mediumtri = new Triceritots() { Size = ServingSize.Medium };
                var largetri = new Triceritots() { Size = ServingSize.Large };

                var smallcoffe = new CrustaceousCoffee() { Size = ServingSize.Small };
                var medcoffe = new CrustaceousCoffee() { Size = ServingSize.Medium };
                var largecoffe = new CrustaceousCoffee() { Size = ServingSize.Large };
                var smallcola = new Plilosoda() { Size = ServingSize.Small, Flavor = SodaFlavor.Cola };
                var smallcherrycola = new Plilosoda() { Size = ServingSize.Small, Flavor = SodaFlavor.CherryCola };
                var smallDoctorDino = new Plilosoda() { Size = ServingSize.Small, Flavor = SodaFlavor.DoctorDino };
                var smallLemonLime = new Plilosoda() { Size = ServingSize.Small, Flavor = SodaFlavor.LemonLime };
                var smallDinoDew = new Plilosoda() { Size = ServingSize.Small, Flavor = SodaFlavor.DinoDew };
                var mediumcola = new Plilosoda() { Size = ServingSize.Medium, Flavor = SodaFlavor.Cola };
                var mediumcherrycola = new Plilosoda() { Size = ServingSize.Medium, Flavor = SodaFlavor.CherryCola };
                var mediumDoctorDino = new Plilosoda() { Size = ServingSize.Medium, Flavor = SodaFlavor.DoctorDino };
                var mediumLemonLime = new Plilosoda() { Size = ServingSize.Medium, Flavor = SodaFlavor.LemonLime };
                var mediumlDinoDew = new Plilosoda() { Size = ServingSize.Medium, Flavor = SodaFlavor.DinoDew };
                var largecola = new Plilosoda() { Size = ServingSize.Large, Flavor = SodaFlavor.Cola };
                var largecherrycola = new Plilosoda() { Size = ServingSize.Large, Flavor = SodaFlavor.CherryCola };
                var largeDoctorDino = new Plilosoda() { Size = ServingSize.Large, Flavor = SodaFlavor.DoctorDino };
                var largeLemonLime = new Plilosoda() { Size = ServingSize.Large, Flavor = SodaFlavor.LemonLime };
                var largeDinoDew = new Plilosoda() { Size = ServingSize.Large, Flavor = SodaFlavor.DinoDew };


                fullMenu.Add(all);
                fullMenu.Add(bro);
                fullMenu.Add(carcheese);
                fullMenu.Add(doubleDeino);
                fullMenu.Add(dino);
                fullMenu.Add(pre);
                fullMenu.Add(wings);
                fullMenu.Add(trex);
                fullMenu.Add(wraptor);


                fullMenu.Add(smallfry);
                fullMenu.Add(mediumfry);
                fullMenu.Add(largefry);
                fullMenu.Add(smallmnc);
                fullMenu.Add(mediummnc);
                fullMenu.Add(largemnc);
                fullMenu.Add(smallms);
                fullMenu.Add(mediumms);
                fullMenu.Add(largems);
                fullMenu.Add(smalltri);
                fullMenu.Add(mediumtri);
                fullMenu.Add(largetri);

                fullMenu.Add(smallcoffe);
                fullMenu.Add(medcoffe);
                fullMenu.Add(largecoffe);

                fullMenu.Add(smallcola);
                fullMenu.Add(smallcherrycola);
                fullMenu.Add(smallDoctorDino);
                fullMenu.Add(smallLemonLime);
                fullMenu.Add(smallDinoDew);

                fullMenu.Add(mediumcola);
                fullMenu.Add(mediumcherrycola);
                fullMenu.Add(mediumDoctorDino);
                fullMenu.Add(mediumLemonLime);
                fullMenu.Add(mediumlDinoDew);

                fullMenu.Add(largecola);
                fullMenu.Add(largecherrycola);
                fullMenu.Add(largeDoctorDino);
                fullMenu.Add(largeLemonLime);
                fullMenu.Add(largeDinoDew);

                return fullMenu;

            }
        }

        /// <summary>
        /// Gets the possible types
        /// </summary>
        public static string[] Types
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        /// <summary>
        /// Search the items in FullMenu for matches
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>The results of the search</returns>
        public static IEnumerable<IMenuItem> Search(string terms)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            // null check
            if (terms == null) return FullMenu;
            string[] splittedSearchTerms = terms.Split(' ');
            foreach (IMenuItem item in FullMenu)
            {
                foreach (string s in splittedSearchTerms)
                {
                    // Add the item if the name is a match
                    if ((item.Name != null && item.Name.Contains(s, StringComparison.CurrentCultureIgnoreCase)) || (item.Description != null && item.Description.Contains(s, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="types">The types to include</param>
        /// <returns>A collection containing only items that match the filter</returns>
        public static IEnumerable<IMenuItem> FilterByType(IEnumerable<IMenuItem> items, IEnumerable<string> types)
        {
            // If no filter is specified, just return the provided collection
            if (types == null || types.Count() == 0) return items;
            // Filter the supplied collection of items
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (item.Type != null && types.Contains(item.Type))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items
        /// to those with calories falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered item collection</returns>
        public static IEnumerable<IMenuItem> FilterByCalories(IEnumerable<IMenuItem> items, uint? min, uint? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IMenuItem>();
            // only a maximum specified
            if (min == null)
            {
                foreach (IMenuItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IMenuItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IMenuItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items
        /// to those with prices falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered item collection</returns>
        public static IEnumerable<IMenuItem> FilterByPrice(IEnumerable<IMenuItem> items, decimal? min, decimal? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IMenuItem>();
            // only a maximum specified
            if (min == null)
            {
                foreach (IMenuItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IMenuItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IMenuItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

    }
}
