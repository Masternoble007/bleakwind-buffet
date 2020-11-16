/*IMenuItem.cs
 * Steven Avila
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A interface for menu items having to implement to the MenuItem.cs
    /// </summary>
     public interface IMenuItem
    {
        /// <summary>
        /// The price of the item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The number of calories of the item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The list of special instruactions for the item
        /// </summary>
        List<string> SpecialInstructions { get; }
        string Description { get; }
    }
}
