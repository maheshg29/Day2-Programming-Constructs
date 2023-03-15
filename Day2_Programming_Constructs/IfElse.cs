using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            {
                Console.WriteLine("Given integers is not Equal");
            }
        }

        //Write a C# Sharp program to check whether a given number is even or odd.
        public void EvenOrOdd(int givenData)
        {
            if (givenData % 2 == 0)
            {
                Console.WriteLine("Given Number is Even Number");
            }
            else
            {
                Console.WriteLine("Ggiven Number is Odd Number");
            }
        }

        //  Write a C# Sharp program to read the age of a candidate and
        //determine whether it is eligible for casting his/her own vote.
        public void VotingEligiblity(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are Eligible For Voting ");
            }
            else
            {
                Console.WriteLine("You are age is below 18 so you are Not Eligible For Voting ");
            }
        }

        //Write a C# Sharp program to find the largest of three numbers.
        public void LargeNumber(int numOne, int numTwo, int numThree)
        {
            if (numOne > numTwo && numOne > numThree)
            {
                Console.WriteLine("Number one is Larg");
            }
            else if (numTwo > numThree && numTwo > numOne)
            {
                Console.WriteLine("Number two is Larg");
            }
            else
            {
                Console.WriteLine("Number Three is Larg");
            }
        }

        // Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria:
        //Marks in Maths >=65
        //Marks in Physics >=55
        //Marks in Chemistry >=50
        //Total in all three subject >=180
        //or
        //Total in Math and(Physics or Chemistry) >=140
        //Test Data :
        //Input the marks obtained in Physics :65
        //Input the marks obtained in Chemistry :51
        //Input the marks obtained in Mathematics :72
        //Expected Output :
        //The candidate is eligible for admission.

        public void AdmissionCriteria(int mathMark, int phycMark, int chemMark)
        {
            if (mathMark + phycMark + chemMark >= 170)
            {
                if (mathMark >= 65 && phycMark >= 55 && chemMark >= 50)
                {
                    Console.WriteLine("The candidate is eligible for admission.");
                }
                else
                {
                    Console.WriteLine("The candidate is Not eligible for admission.");
                }
            }
            else if (mathMark + phycMark >= 140 || mathMark + chemMark >= 140)
            {
                if (mathMark >= 65 && phycMark >= 55 && chemMark >= 50)
                {
                    Console.WriteLine("The candidate is eligible for admission.");
                }
                else
                {
                    Console.WriteLine("The candidate is Not eligible for admission.");
                }
            }
            
        }
    }
}
