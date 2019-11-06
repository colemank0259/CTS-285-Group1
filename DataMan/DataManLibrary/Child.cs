using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataManLibrary
{
    public class Child
    {
        public static void GetChildAnswers()
        {
            // Local variables
            
            int correctUserAnswers = 0;
            int incorrectUserAnswers = 0;
            List<string> answers = new List<string>();

            using (StreamReader fileReader = new StreamReader("Parent_Teacher.csv"))
            {
                fileReader.ReadLine();

                while(!fileReader.EndOfStream)
                {
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');

                    firstNumber.Add(values[0].ToString());
                    symbol.Add(values[1].ToString());
                    secondNumber.Add(values[2].ToString());
                    answers.Add(values[3].ToString());

                }
            }

            for(int i = 0; i < 10; i++)
            {
                int attempts = 0;
                double userAnswer = -1;

                while (attempts < 2 && userAnswer != answers[i])
                {
                    Console.Write($"{firstNumber[i]} {symbol[i]} {firstNumber[i]} = ");
                    userAnswer = TryParse.DoubleTryParse(Console.ReadLine());

                    if (userAnswer == answers[i])
                    {
                        Console.WriteLine("Correct!");
                        correctUserAnswers++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.");
                        incorrectUserAnswers++;
                    }

                    attempts++;
                }

                
            }

            Console.WriteLine($"Correct Answers: {correctUserAnswers}");
            Console.WriteLine($"Incorrect Answers: {incorrectUserAnswers}");
            Console.WriteLine($"Total Questions: {answers.Count}");
        }
    }
}
