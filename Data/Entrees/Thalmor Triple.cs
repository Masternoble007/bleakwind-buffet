/*
 * Author: Steven Avila
 * Class name: Thalmor.cs
 * Purpose: Class used to represent the Thalmor Triple entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class Thalmor_Triple
    {
        /// <summary>
        /// The price of the burger.
        /// </summary>
        public double Price
        {
            get
            {
                return 8.32;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public uint Calories {
            get
            {
                return 943;
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
        /// Whether entree has bacon or not is with the burger.
        /// </summary>
        private bool bacon = true;

        /// <summary>
        /// Gets and sets the bacon.
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
            }
        }

        /// <summary>
        /// Whether entree has eggs or not is with the burger.
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// Gets and sets the bacon.
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
                if (!Tomato) si.Add("Hold the tomatoes.");
                if (!Lettuce) si.Add("Hold the lettuce.");
                if (!Mayo) si.Add("Hold the mayo.");
                if (!Bacon) si.Add("Hold the bacon.");
                if (!Egg) si.Add("Hold the eggs.");

                return si;
            }
        }

        /// <summary>
        /// Creates and returns a string for this object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
