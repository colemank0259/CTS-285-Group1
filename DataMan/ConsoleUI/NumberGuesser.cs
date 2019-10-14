using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class NumberGuesser
    {
        public static void GetNumberGuesser()
        {
            int numOfPlayers;
            int lowNum = 0;
            List<int> guessAmount = new List<int>();

            Console.Write("How many players wish to play > ");
            numOfPlayers = TryParse.IntTryParse();

            for (int i = 1; i <= numOfPlayers; i++)
            {
               
                int userGuess;
                int count = 1;
                bool correct = false;

                Random rnd = new Random();
                int number = rnd.Next(9, 101);      //TODO change to rnd.Next(9, 101)

                do
                {
                    Console.Write($"Player {i} enter your guess");
                    Console.Write(" > ");
                    userGuess = TryParse.IntTryParse();

                    if (userGuess != number)
                    {
                        Console.WriteLine("Incorrect guess!");
                        Console.WriteLine($"The number is between {number - 2} and {number + 2}.");
                        Console.WriteLine();
                        count++;
                    }
                    else if (userGuess == number)
                    {
                        correct = true;
                    }

                } while (correct == false);

                Console.WriteLine($"It took you {count} time(s) to guess the number right.");
                Console.ReadLine();

                guessAmount.Add(count);
                lowNum = guessAmount.Min();
            }
            Console.WriteLine($"");
            Console.WriteLine($"The lowest num was {lowNum}");
            Console.ReadLine();
        }
    }
}
