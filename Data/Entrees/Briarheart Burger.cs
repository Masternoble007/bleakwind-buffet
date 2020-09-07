/*
 * Author: Steven Avila
 * Class name: Brairheart Burger.cs
 * Purpose: Class used to represent the Brairheart Burger entree.
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class Briarheart_Burger
    {
        /// <summary>
        /// The price of the burger.
        /// </summary>
        public double price = 6.32;

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public uint calories = 743;

        /// <summary>
        /// Whether entree has a bun or not is with the burger.
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// List to tell what is not added.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (!Bun) si.Add("Hold the bun.");
                if (!Ketchup) si.Add("Hold the ketchup.");
                if (!Mustard) si.Add("Hold the mustard.");
                if (!Pickle) si.Add("Hold the pickle.");
                if (!Cheese) si.Add("Hold the cheese.");

                return si;
            }
        }

        /// <summary>
        /// Gets and sets the bun.
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
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
            }
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
