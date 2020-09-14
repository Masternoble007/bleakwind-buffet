/*
 * Author: Steven Avila
 * Class name: Garden Orc Omelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class Garden_Orc_Omelette : Entree
    {
        /// <summary>
        /// Sets up the size with the price for the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.57;
            }

        }

        /// <summary>
        /// Sets up the price for the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 404;
            }

        }

        /// <summary>
        /// To put broccoli in the salad or not.
        /// </summary>
        private bool broccoli = true;

        /// <summary>
        /// Gets and sets the broccoli.
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set
            {
                broccoli = value;
            }
        }

        /// <summary>
        /// To put mushrooms in the salad or not.
        /// </summary>
        private bool mushrooms = true;

        /// <summary>
        /// Gets and sets the mushrooms.
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                mushrooms = value;
            }
        }

        /// <summary>
        /// To put tomatoes in the salad or not.
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Gets and sets the tomatoes.
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
        /// To put cheddar in the salad or not.
        /// </summary>
        private bool cheddar = true;

        /// <summary>
        /// Gets and sets the cheddar.
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set
            {
                cheddar = value;
            }
        }

        /// <summary>
        /// What it says to not put in the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (!Broccoli) si.Add("Hold the broccoli.");
                if (!Mushrooms) si.Add("Hold the mushrooms.");
                if (!Tomato) si.Add("Hold the tomatoes.");
                if (!Cheddar) si.Add("Hold the cheddar.");

                return si;
            }
        }

        /// <summary>
        /// Creates and returns a string for this object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
