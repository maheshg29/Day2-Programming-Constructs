﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programming_Constructs
{
    public class IfElse
    {
        //1.Write a C# Sharp program to accept two integers and check whether
        //they are equal or not.
        public void EqualorNot(int valueOne, int valueTwo)
        {
            if (valueOne == valueTwo)
            {
                Console.WriteLine("Given integers is Equal");
            }
            else
                Console.WriteLine("Given integers is not Equal");
        }
    }
}
