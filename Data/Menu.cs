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
using System.Net.Http.Headers;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Retrieves all food items to be used here.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Returns a list of all entrees for the menu.
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees()
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

        /// <summary>
        /// Returns a list of all sides for the menu.
        /// </summary>
        public static IEnumerable<IOrderItem> Sides()
        {
                return new List<Side>
                {
                    new Dragonborn_Waffle_Fries(),
                    new Fried_Miraak(),
                    new Mad_Otar_Grits(),
                    new Vokun_Salad()
                };
        }

        /// <summary>
        /// Returns a list of all drinks for the menu.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
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

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menuItems = new List<IOrderItem>();
            menuItems.AddRange(Entrees());
            menuItems.AddRange(Sides());
            menuItems.AddRange(Drinks());
            return menuItems;
        }

    }
}
