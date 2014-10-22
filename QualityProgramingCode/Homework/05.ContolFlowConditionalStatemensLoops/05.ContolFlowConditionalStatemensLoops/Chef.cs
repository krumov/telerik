using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ContolFlowConditionalStatemensLoops
{
    internal class Chef
    {
        /// <summary>
        /// The Chef's main ability to turn vegetables into a soup.
        /// </summary>
        internal void Cook()
        {
            Bowl bowl = Bowl.GetBowl();

            Vegetable potato = Potato.GetPotato();

            potato.Cut();
            potato.Peel();
            bowl.Add(potato);

            Vegetable carrot = Carrot.GetCarrot();
            carrot.Peel();
            carrot.Cut();
            bowl.Add(carrot);

            if (bowl.ListOfVegetables != null && bowl.ListOfVegetables.Count > 0)
            {
                Console.WriteLine("Your soup is ready sir");
            }
        }
    }
}
