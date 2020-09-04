/*
 * Author: Steven Avila
 * Class name: Candlehearth Coffee.cs
 * Purpose: Class used to represent the Markarth Milk drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
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

        /// <summary>
        /// Size of the drink
        /// </summary>
        public Size size = Size.Small;

        /// <summary>
        /// To add cream to coffee
        /// </summary>
        private bool roomForCream = false;

        /// <summary>
        /// Gets and sets the cream.
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                if (roomForCream == true)
                {
                    SpecialInstructions.Add("Add cream to coffee.");
                }
                else
                {
                    SpecialInstructions.Remove("Add cream to coffee.");
                }
            }
        }

        /// <summary>
        /// To make coffee decaf
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// Gets and sets the decaf.
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                if (decaf == true)
                {
                    SpecialInstructions.Add("Make coffee decaf.");
                }
                else
                {
                    SpecialInstructions.Remove("Make coffee decaf.");
                }
            }
        }

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
                        Price = 0.75;
                        Calories = 7;
                        break;
                    case Size.Medium:
                        Price = 1.25;
                        Calories = 10;
                        break;
                    case Size.Large:
                        Price = 1.75;
                        Calories = 20;
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
