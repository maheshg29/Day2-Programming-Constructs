using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programming_Constructs
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 2 Practice Problem");
            
            IfElse ifElse = new IfElse();
            Console.WriteLine("Enter First value");
            int valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value");
            int valueTwo = Convert.ToInt32(Console.ReadLine());
            ifElse.EqualorNot(valueOne, valueTwo);

        }
    }
}
