/*
 * Author: Steven Avila
 * Class name: Brairheart Burger.cs
 * Purpose: Class used to represent the Brairheart Burger entree.
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Data.Entrees
{
    public class Briarheart_Burger
    {
        /// <summary>
        /// The price of the burger.
        /// </summary>
        private double Price = 6.32;

        /// <summary>
        /// The calories of the burger
        /// </summary>
        private uint Calories = 743;

        /// <summary>
        /// Whether entree has a bun or not is with the burger.
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Gets and sets the bun.
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                if (bun == false)
                {
                    SpecialInstructions.Add("Hold the bun.");
                }
            }
        }

        /// <summary>
        /// Whether entree has ketchup or not is with the burger.
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Gets and sets the ketchup.
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                if (ketchup == false)
                {
                    SpecialInstructions.Add("Hold the ketchup.");
                }
            }
        }

        /// <summary>
        /// Whether entree has mustard or not is with the burger.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Gets and sets the mustard.
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                if (mustard == false)
                {
                    SpecialInstructions.Add("Hold the mustard.");
                }
            }
        }

        /// <summary>
        /// Whether entree has pickle or not is with the burger.
        /// </summary> 
        private bool pickle = true;

        /// <summary>
        /// Gets and sets the pickles.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                if (pickle == false)
                {
                    SpecialInstructions.Add("Hold the pickle.");
                }
            }
        }

        /// <summary>
        /// Whether entree has cheese or not is with the burger.
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Gets and sets the cheese.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                if (cheese == false)
                {
                    SpecialInstructions.Add("Hold the cheese.");
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
        /// Removes pickle
        /// </summary>
        public void holdPickle()
        {
                Pickle = false;
                SpecialInstructions.Add("Hold the pickle.");
        }

        /// <summary>
        /// Removes cheese.
        /// </summary>
        public void holdCheese()
        {
                Cheese = false;
                SpecialInstructions.Add("Hold the cheese.");
        }

        /// <summary>
        /// Creates and returns a string for this object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
