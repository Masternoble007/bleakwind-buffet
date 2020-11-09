using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BleakwindBuffet.Data;
using System.Runtime.CompilerServices;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {


        public IEnumerable<IOrderItem> menu { get; set; }

        /// <summary>
        /// The list of entrees.
        /// </summary>
        public IEnumerable<Entree> Entrees { get; private set; } = null;

        /// <summary>
        /// List of sides
        /// </summary>
        public IEnumerable<Side> Sides { get; private set; } = null;

        public string searchTerms { get; set; }

        /// <summary>
        /// List of drinks.
        /// </summary>
        public IEnumerable<Drink> Drinks { get; private set; } = null;

        public List<Size> Sizes { get; } = new List<Size> { Size.Small, Size.Medium, Size.Large };


        public void OnGet(string searchTerms, IEnumerable<string> categories, int calMin, int calMax, double priMin, double priMax)
        {
            menu = Menu.Search(menu, searchTerms);
            menu = Menu.FilterByCategory(menu, categories);
            menu = Menu.FilterByCalories(menu, calMin, calMax);
            menu = Menu.FilterByPrice(menu, priMin, priMax);
        }

        
    }
}
