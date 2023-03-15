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

            ifElse.EvenOrOdd(valueOne);

            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            ifElse.VotingEligiblity(age);

            Console.WriteLine("Enter first number ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number ");
            int numThree = Convert.ToInt32(Console.ReadLine());
            ifElse.LargeNumber(numOne, numTwo, numThree);

            Console.WriteLine("Enter your Math Mark");
            int mathMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Physics Mark");
            int phyMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Chemistry Mark");
            int chemMark = Convert.ToInt32(Console.ReadLine());
            ifElse.AdmissionCriteria(mathMark, phyMark, chemMark);

            //Switch Statment//
            SwitchStatement switchStatement=new SwitchStatement();
            Console.WriteLine("Enter Day Number in Between 1 to 7");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            switchStatement.WeekdayName(dayNumber);

        }
    }
}
