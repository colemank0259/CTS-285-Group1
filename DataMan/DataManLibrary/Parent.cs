    using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManLibrary
{
    public class Parent
    {
        public static void GetParentEntry()
        {
            // Local variables.
            bool exit = false;
            double firstNumber = 0;
            string symbol = null;
            double secondNumber = 0;
            double correctAnswer = 0;
            double answer = 0;

            try
            {
                Console.WriteLine("Parent/Teacher please enter your 10 problems and solutions.");
                Console.WriteLine("Enter the first number, operator, second number, and the solution.");

                // Create a CSV file.
                StreamWriter outputFile = File.CreateText("Parent_Teacher.csv");
                // Write the initial values to the first line of the CSV file.
                outputFile.WriteLine($"{firstNumber},{symbol},{secondNumber},{answer}");

                // Run through loop 10 times.
                for (int entries = 1; entries <= 10; entries++)
                {
                    Console.Write($"\nProblem {entries}: Enter your First Number > ");
                    firstNumber = TryParse.DoubleTryParse(Console.ReadLine());

                    Console.Write($"\nProblem {entries}: Enter your Symbol > ");
                    symbol = TryParse.SymbolParse(Console.ReadLine());

                    Console.Write($"\nProblem {entries}: Enter your Second Number > ");
                    secondNumber = TryParse.DoubleTryParse(Console.ReadLine());

                    // Send user input to method to get correct answer.
                    correctAnswer = ValidateAnswer(firstNumber, symbol, secondNumber);

                    do
                    {
                        // Get user answer and compare it to correct answer.
                        Console.Write($"\nProblem {entries}: Enter your Answer > ");
                        answer = TryParse.DoubleTryParse(Console.ReadLine());

                        if (answer != correctAnswer)
                        {
                            Console.Write("Your answer doesn't match the correct answer!");
                        }
                        else
                        {
                            exit = true;
                        }
                    } while (exit == false);

                    // Write content to CSV file.
                    outputFile.WriteLine($"{firstNumber},{symbol},{secondNumber},{answer}");
                }
                // Close the CSV file.
                outputFile.Close();
            }
            catch
            {
                Console.WriteLine("Cannot read file!");
            }
        }

        public static double ValidateAnswer(double num1, string symbol, double num2)
        {
            // Local variable.
            double correctAnswer = 0;

            // If/else/if statement to get calculation.
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
                while(num2 == 0)
                {
                    Console.WriteLine("Cannot divide by 0!");
                }
                correctAnswer = num1 / num2;
            }
            else if (symbol.Contains("*"))
            {
                correctAnswer = num1 * num2;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            // Return the correct answer.
            return correctAnswer;
        }
    }
}
