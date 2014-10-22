using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ContolFlowConditionalStatemensLoops
{
    internal class Carrot : Vegetable
    {
        /// <summary>
        /// We ask for carrot
        /// </summary>
        /// <returns>and we got one</returns>
        public static Vegetable GetCarrot()
        {
            return new Carrot();
        }
    }
}
