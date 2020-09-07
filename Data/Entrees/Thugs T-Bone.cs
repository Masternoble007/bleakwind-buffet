/*
 * Author: Steven Avila
 * Class name: Thugs T-Bone.cs
 * Purpose: Class used to represent the entree Thugs T-Bone.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class Thugs_T_Bone
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        public double Price = 6.44;

        /// <summary>
        /// The calories inside the entree
        /// </summary>
        public uint Calories = 982;

        /// <summary>
        /// List to tell what is not added.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();

                return si;
            }
        }

        /// <summary>
        /// Creates and returns a string for this object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
