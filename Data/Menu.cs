/*
 * Author: Steven Avila
 * Class: Menu.cs
 * Purpose: To bring all entree, side, and drink items into a single menu.
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Retrieves all food items to be used here.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Returns a list of all entrees for the menu.
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees
        {
            get
            {
                return new List<Entree>
                {
                    new Briarheart_Burger(),
                    new Double_Draugr(),
                    new Garden_Orc_Omelette(),
                    new Philly_Poacher(),
                    new Smokehouse_Skeleton(),
                    new Thalmor_Triple(),
                    new Thugs_T_Bone()
                };
            }
                
        }

        /// <summary>
        /// Returns a list of all sides for the menu.
        /// </summary>
        public static IEnumerable<IOrderItem> Sides
        {
            get
            {
                return new List<Side>
                {
                    new Dragonborn_Waffle_Fries(),
                    new Fried_Miraak(),
                    new Mad_Otar_Grits(),
                    new Vokun_Salad()
                };
            }
                
        }

        /// <summary>
        /// Returns a list of all drinks for the menu.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks
        {
            get
            {
                return new List<Drink>
                {
                    new Aretino_Apple_Juice(),
                    new CandlehearthCoffee(),
                    new Markarth_Milk(),
                    new Sailor_s_Soda(),
                    new Warrior_Water()
                };
            }
            
        }

        /// <summary>
        /// Gets and returns a list of all available menu items.
        /// </summary>
        public IEnumerable<IOrderItem> AllItems
        {
            get
            {
                List<MenuItem> fullMenu = new List<MenuItem>();
                fullMenu.AddRange((IEnumerable<MenuItem>)Entrees);
                fullMenu.AddRange((IEnumerable<MenuItem>)Sides);
                fullMenu.AddRange((IEnumerable<MenuItem>)Drinks);
                return fullMenu;
            }
        }

        /// <summary>
        /// A search function to find items that match the search function
        /// </summary>
        /// <param name="menuitems">All of the menu items to search</param>
        /// <param name="searchInput">The string input to find</param>
        /// <returns>A list items that matched the search.</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> menuitems, string searchInput)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in menuitems)
            {
                if (item.ToString().ToLower().Contains(searchInput.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// A filter to find items in a particular food section (entree, drink, side)
        /// </summary>
        /// <param name="menuitems">All of the menu items to search</param>
        /// <param name="categories">The categories to check the item with.</param>
        /// <returns>A lsit of items that match the catogories</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menuitems, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0) return menuitems;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in menuitems)
            {
                if (item.GetType().Equals(categories.GetType()))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// A filter to find items between calories min and max.
        /// </summary>
        /// <param name="menuitems">All of the menu items to search</param>
        /// <param name="min">Minimum amount of calories to search.</param>
        /// <param name="max">Maximum amount of calories to search.</param>
        /// <returns>The list of items that match the calorie size.</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menuitems, int? min, int? max)
        {
            if (min == null && max == null) return menuitems;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in menuitems)
            {
                if(item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menuItems, double? min, double? max)
        {
            if (min == null && max == null) return menuItems;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in menuItems)
            {
                if(item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

    }
}
