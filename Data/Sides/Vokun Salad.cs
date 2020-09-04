/*
 * Author: Steven Avila
 * Class name: Vokun Salad.cs
 * Purpose: Class used to represent the Vokun Salad.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class Vokun_Salad
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
        /// Size of the salad.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Sets up the size with the price and calories for the salad
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
                        Price = 0.93;
                        Calories = 41;
                        break;
                    case Size.Medium:
                        Price = 1.28;
                        Calories = 52;
                        break;
                    case Size.Large:
                        Price = 1.82;
                        Calories = 73;
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
            sb.Append(size + " Vokun Salad");
            return sb.ToString();
        }

    }
}
