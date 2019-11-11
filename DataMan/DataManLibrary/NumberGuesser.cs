using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManLibrary
{
    public class NumberGuesser
    {
        public static void GetNumberGuesser()
        {
            int numOfPlayers;       // Local variable.

            Random rnd = new Random();      // Create a new random instance.
            List<int> score = new List<int>();      // Create a list of integers.

            Console.WriteLine("\nWelcome to Number Guesser!");
            Console.WriteLine("This program allows you try to guess a random number between 9 and 100.");
            Console.WriteLine("You can play by yourself or with friends.\n");
            Console.Write("How many players wish to play > ");
            numOfPlayers = TryParse.IntTryParse(Console.ReadLine());

            // For loop to iterate through for each player.
            for (int i = 1; i <= numOfPlayers; i++)
            {
                int userGuess;
                int count = 1;
                bool correct = false;
                int number = rnd.Next(9, 101);   
                int rangeNum = rnd.Next(1, 25);
                int rangeNum2 = rnd.Next(1, 25);

                // Run do while loop until user guesses right answer.
                do
                {
                    Console.Write($"\nPlayer {i} enter your guess");
                    Console.Write(" > ");
                    userGuess = TryParse.IntTryParse(Console.ReadLine());

                    // Run through this loop if user guesses wrong answer.
                    if (userGuess != number)
                    {
                        Console.WriteLine("Incorrect guess!");
                        Console.WriteLine($"The number is between {number - rangeNum} and {number + rangeNum2}.");
                        Console.WriteLine();
                        count++;    // Accumulation for incorrect guesses.
                    }
                    else if (userGuess == number)
                    {
                        correct = true;
                    }
                } while (correct == false);

                score.Add(count);   // Add the amount of guesses from user to list.
            }

            Console.WriteLine();
            for(int j = 0; j < score.Count; j ++)       // Displays the contents of the list.
            {
                Console.WriteLine($"Player {j+1} Total Guesses: {score[j]}");
            }
            Console.WriteLine();
        }
    }
}