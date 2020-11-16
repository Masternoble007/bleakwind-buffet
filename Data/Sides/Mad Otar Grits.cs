/*
 * Author: Steven Avila
 * Class name: Mad Otar Grits.cs
 * Purpose: Class used to represent the mad otar grits.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class Mad_Otar_Grits : Side
    {
        /// <summary>
        /// Size of the pancakes
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
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
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
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
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
            return Size.ToString() + " Mad Otar Grits";
        }

        /// <summary>
        /// A discription of the side
        /// </summary>
        public new string Description()
        {
            return "Cheesey Grits.";
        }
    }
}
