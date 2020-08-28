﻿/*
 * Author: Steven Avila
 * Class name: Aretino Apple Juice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class Aretino_Apple_Juice
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
            }
        }

        /// <summary>
        /// Size of the drink
        /// </summary>
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
                        Price = 0.62;
                        Calories = 44;
                        break;
                    case Size.Medium:
                        Price = 0.87;
                        Calories = 88;
                        break;
                    case Size.Large:
                        Price = 1.01;
                        Calories = 132;
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
            sb.Append(size + " Aretino Apple Juice");
            return sb.ToString();
        }
    }
}
