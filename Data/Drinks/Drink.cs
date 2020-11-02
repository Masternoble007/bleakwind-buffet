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
    public abstract class Drink : MenuItem
    {
        /// <summary>
        /// The size of the drink.
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the flavor of the drink (Sailor Soda.)
        /// </summary>
        public virtual SodaFlavor Flavor { get; set; }

        public virtual bool Ice { get; protected set; } = true;

        public virtual void HoldIce()
        {
            if (Ice)
            {
                Ice = false;
                SI.Add("Hold Ice");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

    }
}
