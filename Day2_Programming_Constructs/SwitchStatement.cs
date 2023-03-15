using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programming_Constructs
{
    public class SwitchStatement
    {
        //Take user input has weekday number to calculate the weekday name:

        public void WeekdayName(int dayNumber)
        {
            switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("It's Monday");
                    break;
                case 2:
                    Console.WriteLine("It's Tuesday");
                    break ;
                case 3:
                    Console.WriteLine("It's Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It's Thursday");
                    break;
                case 5:
                    Console.WriteLine("It's Friday");
                    break;  
                case 6:
                    Console.WriteLine("It's Saturday");
                    break;  
                case 7:
                    Console.WriteLine("It's Sunday");
                    break;  
                default:
                    Console.WriteLine("Please Enter Valid Number inbetween 1 to 7");
                    break;  
            }
        }

        //Take 2 numbers has user inputs and perform arithmetic operations on it.
        // i.e Addition, Subtraction, Multiplication and Division using switch Case.
        public void ArithmaticOperation(int operationNumber, int numberOne,int numberTwo)
        {
            
            switch (operationNumber)
            {

                case 1:
                    int addition = numberOne + numberTwo;
                    Console.WriteLine("Addition of Given number is " + addition);
                    break;
                case 2:
                    int subtraction = numberOne - numberTwo;
                    Console.WriteLine("subtraction of Given number is " + subtraction);
                    break;
                case 3:
                    int Multiplication = numberOne * numberTwo;
                    Console.WriteLine("Multiplication of Given number is " + Multiplication);
                    break;
                case 4:
                    int division = numberOne / numberTwo;
                    Console.WriteLine("Division of Given number is " + division);
                    break;
                default :
                    Console.WriteLine("Please Enter valid Operation Number ");
                    break;
            }
        }
    }
}
