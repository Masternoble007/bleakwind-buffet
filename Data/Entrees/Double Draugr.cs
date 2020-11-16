/*
 * Author: Steven Avila
 * Class name: Double.cs
 * Purpose: Class used to represent the Double Draugr entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class Double_Draugr : Entree
    {
        /// <summary>
        /// Sets up the size with the price for the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.32;
            }

        }

        /// <summary>
        /// Sets up the price for the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 843;
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
                if (!Bun) si.Add("Hold the bun.");
                if (!Ketchup) si.Add("Hold the ketchup.");
                if (!Mustard) si.Add("Hold the mustard.");
                if (!Pickle) si.Add("Hold the pickle.");
                if (!Cheese) si.Add("Hold the cheese.");
                if (!Tomato) si.Add("Hold the tomatoes.");
                if (!Lettuce) si.Add("Hold the lettuce.");
                if (!Mayo) si.Add("Hold the mayo.");

                return si;
            }
        }

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
        /// Whether entree has tomato or not is with the burger.
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Gets and sets the tomato.
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
            }
        }

        /// <summary>
        /// Whether entree has tomato or not is with the burger.
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Gets and sets the lettuce.
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
            }
        }

        /// <summary>
        /// Whether entree has tomato or not is with the burger.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Gets and sets the mayo.
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
            }
        }

        /// <summary>
        /// Creates and returns a string for this object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }

        /// <summary>
        /// A discription of the entree
        /// </summary>
        public new string Description()
        {
            return "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
        }
    }
}
