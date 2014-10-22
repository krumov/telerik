namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {

            for (int i = collection.Count - 1; i > 0; i--)
            {
                var maxIndex = 0; // maxIndex keeps track of index of next maximum element in the array

                // this for loop is for finding next maximum element index

                for (int j = 1; j <= i; j++)
                {
                    // if current element if greater than element at maxIndex, then update maxIndex
                    if (collection[j].CompareTo(collection[maxIndex]) > 0)
                    {
                        maxIndex = j;
                    }
                }
                // Now put the next maximum element in its correct position
                var temp = collection[maxIndex];
                collection[maxIndex] = collection[i];
                collection[i] = temp;
                
            }
        }
    }
}
