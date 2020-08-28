/*
 * Author: Steven Avila
 * Class name: Smokehouse Skeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class Smokehouse_Skeleton
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        public double Price = 5.62;

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public uint Calories = 602;

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
                if (sausageLink == false)
                {
                    SpecialInstructions.Add("Hold the sausage.");
                }
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
                if (egg == false)
                {
                    SpecialInstructions.Add("Hold the eggs.");
                }
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
                if (hashBrowns == false)
                {
                    SpecialInstructions.Add("Hold the has browns.");
                }
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
                if (pancake == false)
                {
                    SpecialInstructions.Add("Hold the pancake.");
                }
            }
        }

        /// <summary>
        /// Holds the strings on what to hold
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
            return "Smokehouse Skeleton";
        }
    }
}
