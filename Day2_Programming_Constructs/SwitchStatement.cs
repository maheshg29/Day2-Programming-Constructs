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
    }
}
