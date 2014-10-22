using System;

namespace StringEscaping
{
    class StringEscaping
    {
        static void Main()
        {
            const string escapedWithSlashes = "The \"use\" of quotations causes difficulties.";
            const string withoutQuotes = "The use of quotations causes difficulties.";
            Console.WriteLine(escapedWithSlashes);
            Console.WriteLine(withoutQuotes);
        }
    }
}

