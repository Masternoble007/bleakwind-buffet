/*
 * Author: Steven Avila
 * Class name: Mad Otar Grits.cs
 * Purpose: Class used to represent the mad otar grits.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Sides
{
    public class Mad_Otar_Grits
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
                        Price = 1.22;
                        Calories = 105;
                        break;
                    case Size.Medium:
                        Price = 1.58;
                        Calories = 142;
                        break;
                    case Size.Large:
                        Price = 1.93;
                        Calories = 179;
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
            sb.Append(size + " mad otar grits");
            return sb.ToString();
        }
    }
}
