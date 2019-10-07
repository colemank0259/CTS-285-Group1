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
            int userAnswer = 0;
            int correctAnswer = 0;
            
            // Loop for creating math problems
            for (int i = 0; i <= QUESTION_AMOUNT; i++)
            {
                num1 = rand.Next(1, 100);
                num2 = rand.Next(1, 100);
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
                        //TODO
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid response. Must be greater than 0."); 
                }

               
            }
        }
        

    }
}
