using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AnswerChecker
    {
        public static void RunAnswerChecker()
        {
            string symbol = " ";
            int number1;
            int number2;
            int userAnswer = 0;
            int correctAnswer = 1;
            int index = 0;

            Console.Write("Enter your first number: > ");
            number1 = int.Parse(Console.ReadLine());

            while (!symbol.Contains("+") && !symbol.Contains("-") && !symbol.Contains("/") && !symbol.Contains("*"))
            {
                Console.Write("Enter a symbol ( +, -, /, * ): > ");
                symbol = Console.ReadLine();
            }

            Console.Write("Enter your second number: > ");
            number2 = int.Parse(Console.ReadLine());

            while (index < 2 && userAnswer != correctAnswer)
            {
                userAnswer = 0;
                correctAnswer = 1;

                Console.Write("Enter your answer: > ");
                userAnswer = int.Parse(Console.ReadLine());


                if (symbol.Contains("+"))
                {
                    correctAnswer = number1 + number2;
                }
                else if (symbol.Contains("-"))
                {
                    correctAnswer = number1 - number2;
                }
                else if (symbol.Contains("/"))
                {
                    if (number2 != 0)
                    {
                        correctAnswer = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Can not divide by zero");
                    }
                }
                else if (symbol.Contains("*"))
                {
                    correctAnswer = number1 * number2;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }


                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("You are correct {0} {1} {2} = {3}", number1, symbol, number2, userAnswer);
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!");
                }
                
                index++;
            }


            if(userAnswer != correctAnswer)
            {
                Console.WriteLine("{0} {1} {2} = {3}", number1, symbol, number2, correctAnswer);
            }
            Console.ReadLine();
        }
    }
}
