using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MeaningfullClass
{
    const int maxCount = 6;
    class SubClassOfMeaningfullClass
    {
        void VariableToString(bool variable)
        {
            string variableToString = variable.ToString();
            Console.WriteLine(variableToString);
        }
    }
    public static void Main()
    {
        MeaningfullClass.SubClassOfMeaningfullClass instance =
          new MeaningfullClass.SubClassOfMeaningfullClass();
        instance.ToString(true);
    }
}