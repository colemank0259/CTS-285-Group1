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
            double userAnswer = 0;
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
                Console.Write($"{firstNumber[i]} {symbol[i]} {firstNumber[i]} = ");
                userAnswer = double.Parse(Console.ReadLine());

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
            }

            Console.WriteLine($"Correct Answers: {correctUserAnswers}");
            Console.WriteLine($"Incorrect Answers: {incorrectUserAnswers}");
        }
    }
}
