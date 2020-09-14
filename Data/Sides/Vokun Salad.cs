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
    public class Vokun_Salad : Side
    {

        /// <summary>
        /// Size of the salad.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Sets up the size with the price for the side.
        /// </summary>
        public override double Price
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
        }

        /// <summary>
        /// Sets up the size with the calories for the side.
        /// </summary>
        public override uint Calories
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
        }

        /// <summary>
        /// Gets instructions for the side.
        /// </summary>
        public override List<string> SpecialInstructions
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
            return Size.ToString() + " Vokun Salad";
        }

    }
}
