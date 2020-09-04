/*
 * Author: Steven Avila
 * Class name: Philly Poacher.cs
 * Purpose: Class used to represent the Philly Poacher entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class Philly_Poacher
    {
        /// <summary>
        /// 
        /// </summary>
        public double Price = 7.23;

        /// <summary>
        /// 
        /// </summary>
        public uint Calories = 784;

        /// <summary>
        /// Whether the sirloin is in the entree.
        /// </summary>
        private bool sirloin = true;

        /// <summary>
        /// Gets and sets the sirloin.
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set
            {
                sirloin = value;
                if (sirloin == false)
                {
                    SpecialInstructions.Add("Hold the sirloin.");
                }
                else
                {
                    SpecialInstructions.Remove("Hold the sirloin.");
                }
            }
        }

        /// <summary>
        /// Whether the onions is in the entree.
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Gets and sets the onion.
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set
            {
                onion = value;
                if (onion == false)
                {
                    SpecialInstructions.Add("Hold the onions.");
                }
                else
                {
                    SpecialInstructions.Remove("Hold the onions.");
                }
            }
        }

        /// <summary>
        /// Whether the rolls is in the entree.
        /// </summary>
        private bool roll = true;

        /// <summary>
        /// Gets and sets the roll.
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                if (roll == false)
                {
                    SpecialInstructions.Add("Hold the rolls.");
                    
                }
                else
                {
                    SpecialInstructions.Remove("Hold the rolls.");
                }
            }
        }

        /// <summary>
        /// List to tell what is not added.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get;
        }

        /// <summary>
        /// Creates and returns a string for this object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
