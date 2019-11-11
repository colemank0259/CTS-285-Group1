using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManLibrary
{
    public class AnswerChecker
    {
        public static void GetAnswerChecker()
        {
            // named constant
            const int QUESTION_AMOUNT = 10;
            // local variables
            int num1;
            int num2;
            int answeredRight = 0;

            Console.WriteLine("\nWelcome to Answer Checker!");
            Console.WriteLine("This program allows you enter a math problem");
            Console.WriteLine("and the program will give you the correct answer.");

            for (int index = 0; index < QUESTION_AMOUNT; index++)
            {
                
                // inline variables to allow for reset in the forloop
                string symbol = " ";
                int userAnswer = 0;
                int correctAnswer = 1000000;
                int attempts = 0;

                // Gets the user's first number for calculation by entering class method for validation.
                Console.Write("\nFirst Number: > ");
                num1 = TryParse.IntTryParse(Console.ReadLine());

                // Gets the user's symbol for calculation by entering class method for validation.
                Console.Write("Enter a symbol (+, -, /, *): > ");
                symbol = TryParse.SymbolParse(Console.ReadLine());

                // Gets the user's second number for calculation by entering class method for validation.
                Second:
                Console.Write("Second Number: > ");
                num2 = TryParse.IntTryParse(Console.ReadLine());
                    
                // while loop to make sure the user gets 2 attempts unless they get the right answer
                while (attempts < 2 && userAnswer != correctAnswer)
                {
                    // Gets the user's answer for calculation by entering class method for validation.
                    Console.Write("Answer: > ");
                    userAnswer = TryParse.IntTryParse(Console.ReadLine());
                    
                    // if statement allows for creation of the correct answer based on symbol user entered
                    if (symbol.Contains("+"))
                    {
                        correctAnswer = num1 + num2;
                    }
                    else if (symbol.Contains("-"))
                    {
                        correctAnswer = num1 - num2;
                    }
                    else if (symbol.Contains("/"))
                    {
                        // stops the user from using zero. goto to send user to the second answer input.
                        if (num2 != 0)
                        {
                            correctAnswer = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Can not divide by zero");
                            goto Second;
                        }
                    }
                    else if (symbol.Contains("*"))
                    {
                        correctAnswer = num1 * num2;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }

                    // Displays if correct
                    if (userAnswer == correctAnswer)
                    {
                        Console.WriteLine($"Correct! {num1} {symbol} {num2} = {userAnswer}");
                        answeredRight++;
                    }
                    else
                    {
                        Messages.ErrorMessage();
                    }

                    attempts++;
                }

                // displays after second incorrect answer
                if (userAnswer != correctAnswer)
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {correctAnswer}");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Correct Answers: {answeredRight}");     // displays amount answered right
            Console.WriteLine($"Total Questions: {QUESTION_AMOUNT}");   // dipslays total amount of questions asked
            Console.WriteLine();
        }
    }
}
