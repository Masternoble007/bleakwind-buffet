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
    public class Dragonborn_Waffle_Fries : Side
    {
        /// <summary>
        /// Size of the fries
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
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
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
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
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
            return Size.ToString() + " Dragonborn Waffle Fries";
        }

        /// <summary>
        /// A discription of the side
        /// </summary>
        public new string Description()
        {
            return "Crispy fried potato waffle fries.";
        }
    }
}
