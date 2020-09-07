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
        private double price;

        /// <summary>
        /// The calories of the side.
        /// </summary>
        private uint calories;

        /// <summary>
        /// Size of the salad.
        /// </summary>
        private Size size;

        /// <summary>
        /// Sets / gets the private size of the side.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Sets up the size with the price for the side.
        /// </summary>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
            set
            {
                price = value;
            }
        }

        /// <summary>
        /// Sets up the size with the calories for the side.
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
            set
            {
                calories = value;
            }
        }

        /// <summary>
        /// Gets instructions for the side.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();

                return si;
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
