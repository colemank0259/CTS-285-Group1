using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManLibrary
{
    public class MemoryBank
    {
        public static void GetRandomProblem()
        {
            // Named constants
            const int QUESTION_AMOUNT = 10;

            // Local variables
            Random rand = new Random();
            int num1 = 0;
            int num2 = 0;
            char[] operators = { '+', '-', '*', '/' };
            char randomOp = ' ';
            int userAnswer = -1; 
            int correctAnswer = 0;
            int correct = 0;

            // Display description of the Memory Bank activity
            Console.WriteLine("\nWelcome to Memory Bank!");
            Console.WriteLine("This program will give you 10 math problems that you can solve.");
            Console.WriteLine("You will get two attempts to get the answer correct.");
            Console.WriteLine("NOTE: Round answers down to the previous integer.");

            // Consume the next line for appearance
            Console.WriteLine("");

            // Loop for creating math problems
            for (int i = 0; i < QUESTION_AMOUNT; i++)
            {
                int attempts = 0;
                num1 = rand.Next(1, 10);
                num2 = rand.Next(1, 10);
                randomOp = operators[rand.Next(operators.Length)];

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

                while (attempts < 2 && userAnswer != correctAnswer)
                {
                    Console.Write($"{num1} {randomOp} {num2} = ");
                    userAnswer = TryParse.IntTryParse(Console.ReadLine());

                    if(userAnswer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        correct++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    attempts++;
                }

                // Consume next line for appearance
                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine($"Correct Answers: {correct}");     // displays amount answered right
            Console.WriteLine($"Total Questions: {QUESTION_AMOUNT}");   // dipslays total amount of questions asked
            Console.WriteLine();
        }
    }
}
