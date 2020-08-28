/*
 * Author: Steven Avila
 * Class name: Garden Orc Omelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class Garden_Orc_Omelette
    {

        /// <summary>
        /// tells the price of the entree.
        /// </summary>
        public double Price = 4.57;

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public uint Calories = 404;

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
                if (broccoli == false)
                {
                    SpecialInstructions.Add("Hold the broccoli.");
                }
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
                if (mushrooms == false)
                {
                    SpecialInstructions.Add("Hold the mushrooms.");
                }
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
                if (tomato == false)
                {
                    SpecialInstructions.Add("Hold the tomatoes.");
                }
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
                if (cheddar == false)
                {
                    SpecialInstructions.Add("Hold the cheddar.");
                }
            }
        }

        /// <summary>
        /// What it says to not put in the entree
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
            return "Garden Orc Omelette";
        }
    }
}
