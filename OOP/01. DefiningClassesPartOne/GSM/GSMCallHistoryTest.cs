using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GSMCallHistoryTest
{
    static void Main()
    {
        GSM phone = new GSM("Moto X", "Motorola");

        phone.AddCall(DateTime.Now, "0899789987", 500);
        phone.AddCall(new DateTime(2013, 2, 16), "0899233987", 350);
        phone.AddCall(new DateTime(2013, 2, 12), "0899123456", 58);
        phone.AddCall(new DateTime(2013, 2, 13), "0899123456", 58);
        phone.AddCall(new DateTime(2013, 2, 14), "0899123456", 69);
        phone.AddCall(new DateTime(2013, 2, 14), "0899123456", 69);
        Console.WriteLine(phone.ToString());
        phone.ShowCallHistory();
        phone.CalcPrice(0.37M);
        phone.RemoveLongestCall();
        phone.CalcPrice(0.37M);
        phone.ClearHistory();
        phone.ShowCallHistory();
    }
}

