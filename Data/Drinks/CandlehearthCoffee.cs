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
    public class CandlehearthCoffee : Drink
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
        /// Size of the drink
        /// </summary>
        private Size size = Size.Small;

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
            }
        }

        /// <summary>
        /// Gets instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (Ice) si.Add("Add ice.");
                if (RoomForCream) si.Add("Add cream to coffee.");


                //if (si.Count == 0) si.Add("No special instructions.");

                return si;
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
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException("Should never be reached");
                }
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
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
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
            StringBuilder sb = new StringBuilder();
            if (Decaf)
            {
                return Size.ToString() + " Decaf Candlehearth Coffee";
            }
            else
            {
                return Size.ToString() + " Candlehearth Coffee";
            }
            
        }
    }
}
