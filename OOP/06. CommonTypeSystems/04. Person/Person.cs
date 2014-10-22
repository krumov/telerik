﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Person
{
    public class Person
    {
        string name;
        int? age;

        public Person(string name, int? age = null)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            string msg = name + " ";
            if (age == null)
            {
                msg += "age not specified";
            }
            else
                msg += age;

            return msg;
        }

    }
}
