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
            
            
            // Loop for creating math problems
            for (int i = 0; i <= QUESTION_AMOUNT; i++)
            {
                int index = 0;
                int userAnswer = 0;
                int correctAnswer = 1;

                num1 = rand.Next(1, 5);
                num2 = rand.Next(1, 5);
                randomOp = operators[rand.Next(operators.Length)];


                while (index < 2 && correctAnswer != userAnswer)
                {

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
                            default:
                                Console.WriteLine("INvalid");
                                break;
                        }

                    }
                    else
                    {
                       Console.WriteLine("Not a valid response. Must be greater than 0.");
                    }

                    if (userAnswer == correctAnswer)
                    {
                        Console.WriteLine(" it works");
                    }
                    else
                    {
                        Console.WriteLine("It does not work");
                    }

                    index++;
                }
            }
        }
    }
}
