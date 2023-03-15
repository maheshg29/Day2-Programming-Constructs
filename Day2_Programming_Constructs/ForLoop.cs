using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programming_Constructs
{
    public class ForLoop
    {
        //Write a program that takes a user input n and prints a table of the powers
        //of 2 that are less than or equal to 2^n.

        public void PowerOf2(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
    }
}
