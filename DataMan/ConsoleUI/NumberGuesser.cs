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

            Random rnd = new Random();
            List<int> score = new List<int>();

            Console.Write("How many players wish to play > ");
            numOfPlayers = TryParse.NewTryParse(Console.ReadLine());

            for (int i = 1; i <= numOfPlayers; i++)
            {
                int userGuess;
                int count = 1;
                bool correct = false;
                int number = rnd.Next(9, 101);          //TODO change to correct numbers.

                do
                {
                    Console.Write($"Player {i} enter your guess");
                    Console.Write(" > ");
                    userGuess = TryParse.NewTryParse(Console.ReadLine());

                    if (userGuess > number)
                    {
                        Console.WriteLine("Incorrect guess!");
                        Console.WriteLine($"The number is between 9 and {userGuess}.");
                        Console.WriteLine();
                        count++;
                    }
                    else if (userGuess < number)
                    {
                        Console.WriteLine("Incorrect guess!");
                        Console.WriteLine($"The number is between {userGuess} and 100.");
                        Console.WriteLine();
                        count++;
                    }



                    //if (userGuess != number)
                    //{
                    //    Console.WriteLine("Incorrect guess!");
                    //    Console.WriteLine($"The number is between {number} and {number}.");
                    //    Console.WriteLine();
                    //    count++;
                    //}
                    else if (userGuess == number)
                    {
                        correct = true;
                    }
                } while (correct == false);

                score.Add(count);
            }

            for(int j = 0; j < score.Count; j ++)
            {
                Console.WriteLine($"Player {j+1} took {score[j]} guesses to get the right number.");
            }
        }
    }
}