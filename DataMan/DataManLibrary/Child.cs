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
            List<double> firstNumber = new List<double>();
            List<string> symbol = new List<string>();
            List<double> secondNumber = new List<double>();
            List<double> answers = new List<double>();
            

            // Open the file.
            using (StreamReader fileReader = new StreamReader("Parent_Teacher.csv"))
            {
                // Reads each line of the file.
                fileReader.ReadLine();

                // Reads all lines of file until end 
                while(!fileReader.EndOfStream)
                {
                    // Split line on comma.
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');

                    // Add values to lists.
                    firstNumber.Add(double.Parse(values[0]));
                    symbol.Add(values[1].ToString());
                    secondNumber.Add(double.Parse(values[2]));
                    answers.Add(double.Parse(values[3]));

                }
            }

            Console.WriteLine("\nWelcome to DataBank!");
            Console.WriteLine("This program will give you 10 math problems that you can solve.");
            Console.WriteLine("You will get two attempts to get the answer correct.");

            for (int i = 0; i < 2; i++)
            {
                int attempts = 0;
                double userAnswer = -1;

                // While user answer is incorrect and haven't answered twice.
                while (attempts < 2 && userAnswer != answers[i])
                {
                    // Get user answer.
                    Console.Write($"\n{firstNumber[i]} {symbol[i]} {secondNumber[i]} = ");
                    userAnswer = TryParse.DoubleTryParse(Console.ReadLine());

                    if (userAnswer == answers[i])       // Compare user answer to correct answer.
                    {
                        Console.WriteLine($"Correct! {firstNumber[i]} {symbol[i]} {secondNumber[i]} = {userAnswer}");
                        correctUserAnswers++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.");
                    }
                    attempts++;     // Accumulate attempts.
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Correct Answers: {correctUserAnswers}");
            Console.WriteLine($"Total Questions: {answers.Count}");
            Console.WriteLine();
        }
    }
}
