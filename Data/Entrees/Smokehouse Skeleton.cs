/*
 * Author: Steven Avila
 * Class name: Smokehouse Skeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class Smokehouse_Skeleton : Entree
    {
        /// <summary>
        /// Sets up the size with the price for the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.62;
            }

        }

        /// <summary>
        /// Sets up the price for the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 602;
            }

        }

        /// <summary>
        /// Whether to add sausage to the entree.
        /// </summary>
        private bool sausageLink = true;

        /// <summary>
        /// Gets and sets the sausage.
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set
            {
                sausageLink = value;

            }
        }

        /// <summary>
        /// Whether to add eggs to the entree.
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// Gets and sets the egg.
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
            }
        }

        /// <summary>
        /// Whether to add hash browns to the entree.
        /// </summary>
        private bool hashBrowns = true;

        /// <summary>
        /// Gets and sets the hash browns.
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set
            {
                hashBrowns = value;
            }
        }

        /// <summary>
        /// Whether to add pancakes to the entree.
        /// </summary>
        private bool pancake = true;

        /// <summary>
        /// Gets and sets the pancake.
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                pancake = value;
            }
        }

        /// <summary>
        /// Holds the strings on what to hold
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (!SausageLink) si.Add("Hold the sausage.");
                if (!Egg) si.Add("Hold the eggs.");
                if (!HashBrowns) si.Add("Hold the hashbrowns.");
                if (!Pancake) si.Add("Hold the pancake.");

                return si;
            }
        }

        /// <summary>
        /// Creates and returns a string for this object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
