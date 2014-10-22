using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ContolFlowConditionalStatemensLoops
{
    internal class Potato : Vegetable
    {
        /// <summary>
        /// Any time we need a potato
        /// </summary>
        /// <returns>we get a potato</returns>
        public static Vegetable GetPotato()
        {
            return new Potato();
        }
    }
}
