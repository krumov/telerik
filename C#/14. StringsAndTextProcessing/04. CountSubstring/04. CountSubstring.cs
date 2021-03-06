﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

class CountSubstring
{
    static void Main(string[] args)
    {
        string str = @"We are living in an yellow submarine. We don
       't have anything else. Inside the submarine is very tight. So
       we are drinking all the day. We will move out of it in 5 days.";
        int count = 0;

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str.Substring(i, 2).ToLower() == "in")
            {
                count++;
                i++;
            }
        }
        Console.WriteLine("Result: {0}",count);
    }
}