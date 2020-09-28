/*
 * Author: Steven Avila
 * Class: Drink.cs
 * Purpose: to set an override class for all the drinks
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// The base class representing the common properties of drinks.
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The size of the drink.
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the flavor of the drink (Sailor Soda.)
        /// </summary>
        public virtual SodaFlavor Flavor { get; set; }


        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get;}

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public abstract uint Calories { get;}

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
