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
    public class Philly_Poacher : Entree
    {
        /// <summary>
        /// Sets up the size with the price for the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.23;
            }

        }

        /// <summary>
        /// Sets up the price for the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 784;
            }

        }

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
            }
        }

        /// <summary>
        /// List to tell what is not added.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (!Sirloin) si.Add("Hold the sirloin.");
                if (!Onion) si.Add("Hold the onions.");
                if (!Roll) si.Add("Hold the rolls.");

                return si;
            }
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
