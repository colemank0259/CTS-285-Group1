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

            Player myPlayer = new Player();
            List<Player> score = new List<Player>();

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

                score.Add(new Player(i, count));
                score.Sort(Player.CompareGuesses);
            }

            foreach (Player i in score)
            {
                Console.WriteLine($"Player {i.Players} took {i.GuessAmount} to guess the right number.");
                Console.ReadLine();
            }

            Console.WriteLine($"Player {score[0].Players} wins with only {score[0].GuessAmount} tries");
            Console.ReadLine();
        }
    }
}