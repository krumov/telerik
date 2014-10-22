using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ContolFlowConditionalStatemensLoops
{
    internal class Bowl
    {
        /// <summary>
        /// here we list all the vegetables that are being used for our soup
        /// </summary>
        internal readonly List<Vegetable> ListOfVegetables = new List<Vegetable>();

        /// <summary>
        /// Here we can take a bowl for starting the cooking
        /// </summary>
        /// <returns>a bowl for cooking</returns>
        public static Bowl GetBowl()
        {
            return new Bowl();
        }

        /// <summary>
        /// We add to the bowl only vegetables
        /// that are already been peeled and cut.
        /// </summary>
        /// <param name="vegetable">the vegetable we want to add to our soup</param>
        public void Add(Vegetable vegetable)
        {
            if (vegetable.IsPeeled)
            {
                if (vegetable.IsCut)
                {
                    this.ListOfVegetables.Add(vegetable);
                    Console.WriteLine("{0} is been Cutted and Peeled and added to bowl", vegetable);
                }
                else
                {
                    Console.WriteLine("{0} is not Cutted. Please cut down the vegetable first!", vegetable);
                }
            }
            else
            {
                Console.WriteLine("{0} is not Peeled. Please peel the vegetable first!", vegetable);
            }
        }
    }
}
