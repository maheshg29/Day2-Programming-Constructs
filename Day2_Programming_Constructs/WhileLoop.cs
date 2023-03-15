using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programming_Constructs
{
    public class WhileLoop
    {
        //Perform Flip Coin problem till either Heads or Tails wins 20 times.
        public void FlipCoin()
        {
            Random rnd = new Random();
            int heads = 0;
            int tails = 0;

            while (heads < 20 && tails < 20)
            {
                int result = rnd.Next(2);
                if (result == 0)
                {
                    heads++;
                    Console.WriteLine("Heads");
                }
                else
                {
                    tails++;
                    Console.WriteLine("Tails");
                }
            }

            if (heads == 20)
            {
                Console.WriteLine("Heads wins!");
            }
            else
            {
                Console.WriteLine("Tails wins!");
            }
        }

        //Take a user input word and reverse it using loop.
        public void ReverseString(string userData)
        {
            char[] charArray = userData.ToCharArray();
            string reversedString = String.Empty;
            int loopLenth = charArray.Length -1 ;

            while (loopLenth >= 0)
            {
                reversedString += charArray[loopLenth];
                loopLenth --;
            }
            Console.WriteLine(reversedString);
        }
    }
}
