/*
 * Author: Steven Avila
 * Class name: Sailor's Soda.cs
 * Purpose: Class used to represent the Sailor's Soda drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class Sailor_s_Soda
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        public double price;

        /// <summary>
        /// The amount of calories in the drink
        /// </summary>
        public uint calories;

        /// <summary>
        /// Size of the drink
        /// </summary>
        public Size size;

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
        /// Sets / gets the private size of the drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Soda Flavor
        /// </summary>
        public SodaFlavor sf;

        /// <summary>
        /// Adds instructions for the drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if(!Ice) si.Add("Hold ice.");

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
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
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
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
            set
            {
                calories = value;
            }
        }

        /// <summary>
        /// Sets what flavor the person wants
        /// </summary>
        public SodaFlavor Flavor
        {
            get{
                return sf;
            }
            set
            {
                sf = value;
                switch (value)
                {
                    case SodaFlavor.Watermelon:
                        sf = SodaFlavor.Watermelon;
                        break;
                    case SodaFlavor.Blackberry:
                        sf = SodaFlavor.Blackberry;
                        break;
                    case SodaFlavor.Grapefruit:
                        sf = SodaFlavor.Grapefruit;
                        break;
                    case SodaFlavor.Lemon:
                        sf = SodaFlavor.Lemon;
                        break;
                    case SodaFlavor.Peach:
                        sf = SodaFlavor.Peach;
                        break;
                    case SodaFlavor.Cherry:
                        sf = SodaFlavor.Cherry;
                        break;
                }
            }
        }

        /// <summary>
        /// Gives a message on size, flavor of the soda.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(size + " " + sf + " Sailor Soda");
            return sb.ToString();
        }
    }
}
