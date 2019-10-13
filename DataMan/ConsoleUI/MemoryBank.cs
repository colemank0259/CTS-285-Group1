using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class MemoryBank
    {
        public static void getMemoryBank()
        {
            // Named constants
            const int QUESTION_AMOUNT = 10;

            // Local variables
            string inputString;
            Random rand = new Random();
            int num1 = 0;
            int num2 = 0;
            char[] operators = { '+', '-', '*', '/' };
            char randomOp = ' ';
            double userAnswer = 0;
            double correctAnswer = 0;
            int runAnswer = 0;
            bool run = true;

            // Display description of the Memory Bank activity
            Console.WriteLine("Enter the correct answer to 10 random math problems.");

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

                    if (double.TryParse(inputString, out userAnswer))
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

                    // TODO Find a way to format correct answers to division problems to only two decimal places

                }

                // Prompt the user to repeat the activity
                Console.Write("Enter 1 to repeat the activity or 2 to exit: ");
                inputString = Console.ReadLine();
                if (int.TryParse(inputString, out runAnswer))
                {
                    switch (runAnswer)
                    {
                        case 1:
                            run = true;
                            break;
                        case 2:
                            run = false;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Not a valid response. Must be an integer.");
                }
            } while (run == true);

        }
    }
}
