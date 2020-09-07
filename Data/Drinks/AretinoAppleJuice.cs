/*
 * Author: Steven Avila
 * Class name: Aretino Apple Juice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class Aretino_Apple_Juice
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
        /// Size of the drink
        /// </summary>
        private Size size;

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

        /// <summary>
        /// Sets / gets the private size of the drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Gets instructions for the drink
        /// </summary>
        public List<string> SpecialInstructions
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
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
            set
            {
                price = value;
            }
        }

        /// <summary>
        /// Sets up the size with the calories for the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
            set
            {
                calories = value;
            }
        }

        /// <summary>
        /// Gives a message on size of the soda.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(size + " Aretino Apple Juice");
            return sb.ToString();
        }
    }
}
