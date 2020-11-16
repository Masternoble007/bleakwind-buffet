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
    public class Thugs_T_Bone : Entree
    {
        /// <summary>
        /// The price of the burger.
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.44;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 982;
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

        /// <summary>
        /// A discription of the entree
        /// </summary>
        public new string Description()
        {
            return "Juicy T-Bone, not much else to say.";
        }
    }
}
