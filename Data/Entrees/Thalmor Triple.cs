/*
 * Author: Steven Avila
 * Class name: Thalmor.cs
 * Purpose: Class used to represent the Thalmor Triple entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class Thalmor_Triple
    {
        /// <summary>
        /// The price of the burger.
        /// </summary>
        public double Price = 8.32;

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public uint Calories = 943;

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
                if (tomato == false)
                {
                    SpecialInstructions.Add("Hold the tomato.");
                }
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
                if (lettuce == false)
                {
                    SpecialInstructions.Add("Hold the lettuce.");
                }
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
                if (mayo == false)
                {
                    SpecialInstructions.Add("Hold the mayo.");
                }
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
                if (bacon == false)
                {
                    SpecialInstructions.Add("Hold the bacon.");
                }
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
                if (egg == false)
                {
                    SpecialInstructions.Add("Hold the eggs.");
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
            return "Thalmor Triple";
        }
    }
}
