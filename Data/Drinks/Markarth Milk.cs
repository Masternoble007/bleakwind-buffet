/*
 * Author: Steven Avila
 * Class name: Markarth Milk.cs
 * Purpose: Class used to represent the Markarth Milk drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class Markarth_Milk : Drink
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        public double price;

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public uint calories;

        /// <summary>
        /// Whether to add ice or not.
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// Gets and sets the ice.
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
            }
        }

        public Size size;

        /// <summary>
        /// Gets instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (Ice) si.Add("Add ice.");
                /// if (si.Count == 0) si.Add("No special instructions.");


                return si;
            }
        }

        /// <summary>
        /// Sets up the size with the price for the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Sets up the size with the calories for the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Gives a message on size of the soda.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Markarth Milk";
        }

        /// <summary>
        /// A discription of the drink
        /// </summary>
        public new string Description()
        {
            return "Hormone-free organic 2% milk.";
        }
    }
}
