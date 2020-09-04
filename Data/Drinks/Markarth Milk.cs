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
    public class Markarth_Milk
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        public double Price;

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public uint Calories;

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
                if (ice == true)
                {
                    SpecialInstructions.Add("Add ice.");
                }
                else
                {
                    SpecialInstructions.Remove("Add ice.");
                }
            }
        }

        public Size size = Size.Small;

        /// <summary>
        /// Gets instructions for the drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get;
        }

        /// <summary>
        /// Sets up the size with the price and calories for the drink
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
                        Price = 1.05;
                        Calories = 56;
                        break;
                    case Size.Medium:
                        Price = 1.11;
                        Calories = 72;
                        break;
                    case Size.Large:
                        Price = 1.22;
                        Calories = 93;
                        break;
                }
            }
        }

        /// <summary>
        /// Gives a message on size of the soda.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(size + " Markarth Milk");
            return sb.ToString();
        }
    }
}
