/*
 * Author: Steven Avila
 * Class name: Warrior Water.cs
 * Purpose: Class used to represent the Warrior Water drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class Warrior_Water
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        public double price = 0.00;

        /// <summary>
        /// The amount of calories in the drink
        /// </summary>
        public uint calories = 0;

        /// <summary>
        /// Size of the drink
        /// </summary>
        public Size size;

        /// <summary>
        /// Sets / gets the private size of the drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Adds instructions for the drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (!Ice) si.Add("Hold ice.");
                if (Lemon) si.Add("Add lemon.");

                return si;
            }
        }

        /// <summary>
        /// If ice goes with the drink
        /// </summary>
        private bool ice = true;

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
        /// To add a lemon or not.
        /// </summary>
        private bool lemon = false;

        /// <summary>
        /// Gets and sets the lemon.
        /// </summar>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// Displays the size and drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(size + " warrier water");
            return sb.ToString();
        }
    }
}
