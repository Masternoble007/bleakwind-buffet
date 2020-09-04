/*
 * Author: Steven Avila
 * Class name: Dragonborn Waffle Fries.cs
 * Purpose: Class used to represent the dragonborn waffle fries.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class Dragonborn_Waffle_Fries
    {
        /// <summary>
        /// Prices of the side.
        /// </summary>
        private double Price;

        /// <summary>
        /// The calories of the side.
        /// </summary>
        private uint Calories;

        /// <summary>
        /// Size of the pancakes
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Sets up the size with the price and calories for the pancake
        /// </summary>
        public Size s
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 0.42;
                        Calories = 77;
                        break;
                    case Size.Medium:
                        Price = 0.76;
                        Calories = 89;
                        break;
                    case Size.Large:
                        Price = 0.96;
                        Calories = 100;
                        break;
                }
            }
        }

        /// <summary>
        /// Displays the size of the side.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(size + " dragonborn waffle fries");
            return sb.ToString();
        }
    }
}
