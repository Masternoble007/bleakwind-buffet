/*
 * Author: Steven Avila
 * Class name: Fried Miraak.cs
 * Purpose: Class used to represent the fried miraak.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    class Fried_Miraak
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
                        Price = 1.78;
                        Calories = 151;
                        break;
                    case Size.Medium:
                        Price = 2.01;
                        Calories = 236;
                        break;
                    case Size.Large:
                        Price = 2.88;
                        Calories = 306;
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
            sb.Append(size + " fried miraak");
            return sb.ToString();
        }
    }
}
