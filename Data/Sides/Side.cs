/*
 * Author: Steven Avila
 * Class: Side.cs
 * Purpose: to set an override class for all the sides
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// The base class representing the common properties of sides.
    /// </summary>
    public abstract class Side : MenuItem
    {
        /// <summary>
        /// The size of the side.
        /// </summary>
        public virtual Size Size { get; set; }
    }
}
