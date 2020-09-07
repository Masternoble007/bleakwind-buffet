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
    public class Fried_Miraak
    {
        /// <summary>
        /// Prices of the side.
        /// </summary>
        public double price;

        /// <summary>
        /// The calories of the side.
        /// </summary>
        public uint calories;

        /// <summary>
        /// Size of the pancakes
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
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
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
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
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
            sb.Append(size + " Fried Miraak");
            return sb.ToString();
        }
    }
}
