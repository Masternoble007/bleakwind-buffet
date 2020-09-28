/*
 * Author: Steven Avila
 * Class: Entree.cs
 * Purpose: to set an override class for all the entrees.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// The base class representing the common properties of entrees.
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
