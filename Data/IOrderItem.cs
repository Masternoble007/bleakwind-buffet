/*
 * Author: Steven Avila
 * Class: IOrderItem.cs
 * Purpose: To get the price, calories, and instructions of the item the user wants to order.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// The common properties of the ordered food.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the food item
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the food item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the food item.
        /// </summary>
         string[] SI { get; }
    }
}
