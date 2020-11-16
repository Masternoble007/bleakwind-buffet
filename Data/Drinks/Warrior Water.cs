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
    public class Warrior_Water : Drink
    {
        /// <summary>
        /// Size of the drink
        /// </summary>
        public Size size;

        /// <summary>
        /// Sets up the size with the price for the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.00;
                    case Size.Medium: return 0.00;
                    case Size.Large: return 0.00;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
            set
            {

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
                    case Size.Small: return 0;
                    case Size.Medium: return 0;
                    case Size.Large: return 0;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Adds instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
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
            return Size.ToString() + " warrier water";
        }

        /// <summary>
        /// A discription of the drink
        /// </summary>
        public new string Description()
        {
            return " It’s water. Just water..";
        }
    }
}
