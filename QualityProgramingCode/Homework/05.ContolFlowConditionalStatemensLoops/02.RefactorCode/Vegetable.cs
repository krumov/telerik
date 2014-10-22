﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RefactorCode
{
    internal abstract class Vegetable
    {
        /// <summary>
        /// Gets a value indicating whether the vegetable has been peeled.
        /// </summary>
        internal bool IsPeeled { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the vegetable has been cut down.
        /// </summary>
        internal bool IsCut { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether the vegetable
        /// </summary>
        internal bool IsRotten { get; set; }

        /// <summary>
        /// we can peel our vegetables
        /// </summary>
        public void Peel()
        {
            if (!this.IsRotten)
            {
                this.IsPeeled = true;    
            }
            else
            {
                Console.WriteLine("this vegetable is rotten! I won't cook it");
            }
        }

        /// <summary>
        /// We can cut it down as well.
        /// </summary>
        public void Cut()
        {
            if (this.IsPeeled)
            {
                this.IsCut = true;    
            }
            else
            {
                Console.WriteLine("Peel before Cutting");
            }
        }

        /// <summary>
        /// Overriding ToString method.
        /// </summary>
        /// <returns>the name of the vegetable</returns>
        public override string ToString()
        {
            return this.GetType().Name.ToLower();
        }
    }
}
