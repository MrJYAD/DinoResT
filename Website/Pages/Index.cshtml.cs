using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Data;
namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// The current search terms 
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// The Items to display on the index page 
        /// </summary>
        public IEnumerable<IMenuItem> Items { get; set; }

        /// <summary>
        ///  min calories
        /// </summary>
        public uint? CaloriesMin { get; set; }

        /// <summary>
        ///  max calories
        /// </summary>
        public uint? CaloriesMax { get; set; }

        /// <summary>
        ///  min price
        /// </summary>
        public decimal? PriceMin { get; set; }

        /// <summary>
        ///  max price
        /// </summary>
        public decimal? PriceMax { get; set; }

        /// <summary>
        /// The filtered Type
        /// </summary>
        public string[] Type { get; set; }

        /// <summary>
        /// Initializes the parameters and perform searching and filtering
        /// </summary>
        /// <param name="SearchTerms">The terms of search</param>
        /// <param name="Type">The type of the item to filter</param>
        /// <param name="CaloriesMin">The minimum calories to filter</param>
        /// <param name="CaloriesMax">The Maximum calories to filter</param>
        /// <param name="PriceMin">The minimum price to filter</param>
        /// <param name="PriceMax">The Maximum price to filter</param>
        public void OnGet(string SearchTerms, string[] Type, uint? CaloriesMin, uint? CaloriesMax, decimal? PriceMin, decimal? PriceMax)
        {
            this.SearchTerms = SearchTerms;
            this.Type = Type;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByType(Items, Type);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}