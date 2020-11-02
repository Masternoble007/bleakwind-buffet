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

        public void OnGet()
        {
        }

        /// <summary>
        /// A menu object for the website
        /// </summary>
        public Menu menu { get; private set; } = null;

        /// <summary>
        /// The list of entrees.
        /// </summary>
        public IEnumerable<Entree> Entrees { get; private set; } = null;

        /// <summary>
        /// List of sides
        /// </summary>
        public IEnumerable<Side> Sides { get; private set; } = null;

        /// <summary>
        /// List of drinks.
        /// </summary>
        public IEnumerable<Drink> Drinks { get; private set; } = null;

        public List<Size> Sizes { get; } = new List<Size> { Size.Small, Size.Medium, Size.Large };

        
    }
}
