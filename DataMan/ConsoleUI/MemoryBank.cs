using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class MemoryBank
    {
        public static void GetRandomProblem()
        {
            // Named constants
            const int QUESTION_AMOUNT = 10;

            // Local variables
            string inputString = null;
            Random rand = new Random();
            int num1 = 0;
            int num2 = 0;
            char[] operators = { '+', '-', '*', '/' };
            char randomOp = ' ';
            int userAnswer = 0;
            int correctAnswer = 0;
            string runAnswer = null;
            bool run = true;

            // Display description of the Memory Bank activity
            Console.WriteLine("Enter the correct answer to 10 random math problems.");
            Console.WriteLine("NOTE: Round answers down to the previous integer.");

            // Consume the next line for appearance
            Console.WriteLine("");

            do
            {
                // Loop for creating math problems
                for (int i = 0; i <= QUESTION_AMOUNT; i++)
                {
                    num1 = rand.Next(1, 10);
                    num2 = rand.Next(1, 10);
                    randomOp = operators[rand.Next(operators.Length)];
                    Console.Write($"{num1} {randomOp} {num2} = ");
                    inputString = Console.ReadLine();

                    if (int.TryParse(inputString, out userAnswer))
                    {
                        switch (randomOp)
                        {
                            case '+':
                                correctAnswer = num1 + num2;
                                break;
                            case '-':
                                correctAnswer = num1 - num2;
                                break;
                            case '*':
                                correctAnswer = num1 * num2;
                                break;
                            case '/':
                                correctAnswer = num1 / num2;
                                break;
                        }

                        if (userAnswer == correctAnswer)
                        {
                            Console.WriteLine("Correct!");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect.");
                        }

                        // Consume next line for appearance
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Not a valid response. Must be an integer.");
                    }

                }

                // Prompt the user to repeat the activity
                Console.Write("Enter yes to repeat the activity or no to exit: ");
                runAnswer = Console.ReadLine();

                if (runAnswer == "yes")
                {
                    run = true;
                }
                else
                {
                    run = false;
                }

            } while (run == true);

        }

    }
}
