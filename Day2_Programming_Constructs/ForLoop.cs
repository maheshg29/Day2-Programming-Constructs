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


        //Write a program that reads a number N and prints the sum of squares of N numbers starting from 1.

        public void SumOfSquare(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i * i;
            }

            Console.WriteLine("The sum of squares of {0} numbers starting from 1 is {1}.",number,sum);
        }

        //Write a program that computes a factorial of a number taken as input
        public void FactorialOfNumber(int factorialNumber)
        {
            int factorial = 1;
            for (int i = 1; i <= factorialNumber; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("{0}! = {1}", factorialNumber, factorial);
        }
    }
}
