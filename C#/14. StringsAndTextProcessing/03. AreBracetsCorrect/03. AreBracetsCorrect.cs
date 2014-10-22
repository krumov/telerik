using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

class AreBracetsCorrect
{
    static void Main(string[] args)
    {
         
        string expression = ")((2+3)/2)(";
        CheckIsTheExpresionCorrect(expression);
 
    }
    static void CheckIsTheExpresionCorrect(string expr)
    {
        char[] exprCharArr = expr.ToCharArray();
        int bracket = 0;
 
        bool res = true;
       
        for (int i = 0; i < exprCharArr.Length; i++)
        {
 
            if (exprCharArr[i] == '(')
            {
                bracket++;
            }
            else if (exprCharArr[i] == ')')
            {
                bracket--;
            }
            if (bracket<0)
            {
                break;
            }
        }
        if (bracket == 0)
        {
            Console.WriteLine("The expresion is correct!");
        }
        else
        {
            Console.WriteLine("The expresion is NOT correct!");
        }
    }
    
}
