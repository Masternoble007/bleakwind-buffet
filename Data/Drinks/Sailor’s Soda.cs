/*
 * Author: Steven Avila
 * Class name: Sailor's Soda.cs
 * Purpose: Class used to represent the Sailor's Soda drink.
 */
using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class Sailor_s_Soda
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        public double Price;

        /// <summary>
        /// The amount of calories in the drink
        /// </summary>
        public uint Calories;

        /// <summary>
        /// Size of the drink
        /// </summary>
        public Size si = Size.Small;

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
                if (ice == false)
                {
                    SpecialInstructions.Add("Hold ice.");
                }
            }
        }

        /// <summary>
        /// Soda Flavor
        /// </summary>
        public SodaFlavor sf = SodaFlavor.Cherry;

        /// <summary>
        /// Adds instructions for the drink
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
                return si;
            }            
            set
            {
                si = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 1.42;
                        Calories = 117;
                        break;
                    case Size.Medium:
                        Price = 1.74;
                        Calories = 153;
                        break;
                    case Size.Large:
                        Price = 2.07;
                        Calories = 205;
                        break;
                }
            }
        }

        /// <summary>
        /// Sets what flavor the person wants
        /// </summary>
        public SodaFlavor f
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
            sb.Append(si + " " + sf + " Sailor Soda");
            return sb.ToString();
        }
    }
}
