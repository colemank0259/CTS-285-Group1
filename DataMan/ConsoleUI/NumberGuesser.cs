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
            //TODO ask the user how many players wish to play
            //TODO track the amount of attempts for each player

            string userInfo;
            int userGuess;
            int count = 1;
            int inc = 0;
            bool correct = false;


            Random rnd = new Random();
            int number = rnd.Next(11);      //TODO change to rnd.Next(9, 101)

            do
            {
                Console.Write("Enter your guess");      //TODO validate user input is between 9 - 100.
                Console.Write(" > ");
                userInfo = Console.ReadLine();

                if (int.TryParse(userInfo, out userGuess))
                {
                    if (userGuess != number)
                    {
                        Console.WriteLine("Incorrect guess!");
                        //Console.WriteLine($"The number is between {number - inc} and {number + inc}");
                        Console.WriteLine($"The number is between {number - 2} and {number + 2}.");
                        Console.WriteLine();
                        count++;
                        //inc =+ 2;
                    }
                    else if (userGuess == number)
                    {
                        correct = true;
                    }
                }
                else
                {
                    Console.WriteLine("Not valid input!");
                }
            } while (correct == false);

            Console.WriteLine($"It took you {count} time(s) to guess the number right.");
            Console.ReadLine();
        }
    }
}
