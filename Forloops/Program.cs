using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int actualNumber = rand.Next(1, 10);
            Console.WriteLine("Please guess a number between 1 and 10");
         


            for (int i = 2; i >= 0; i--)
            {
              string guessString = Console.ReadLine();
              int guess;
                
             bool result = int.TryParse(guessString, out guess);
                if (!result)
                {
                    Console.WriteLine("Hey, that wasn't a number!");
                    i++;
                    continue;
                }
                if (guess == actualNumber)
                {
                    Console.WriteLine("You Win");
                    break;
                }
                if (i == 0)
                {
                    Console.WriteLine("You're a Loser, the number was {0} ", actualNumber);
                }
                else
                {
                    Console.WriteLine("Wrong! You have {0} guess{1} left", i, i != 1 ? "es" : string.Empty);
                }
            }

            Console.ReadLine();
        }
    }
}
