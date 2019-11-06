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
            var firstNumber = "First Number";
            var symbol = "Symbol";
            var secondNumber = "Second Number";
            var answer = "answers";
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText("Parent_Teacher.csv");
                Console.WriteLine("Parent/Teacher please enter your 10 problems and solutions.");
                Console.WriteLine("Example: first enter problem (2+2=)\nThen enter solution (4)");
                for (int entries = 1; entries <= 10; entries ++)
                {
                    var newLine = string.Format($"{firstNumber}, {symbol}, {secondNumber}, {answer}");

                    outputFile.WriteLine(newLine);

                    Console.Write($"\nProblem {entries}: Enter your First Number! > ");
                    firstNumber = Console.ReadLine();

                    Console.Write($"\nProblem {entries}: Enter your Symbol! > ");
                    symbol = Console.ReadLine();

                    Console.Write($"\nProblem {entries}: Enter your Second Number! > ");
                    secondNumber =  Console.ReadLine();

                    Console.Write($"\nProblem {entries}: Enter your Answer! > ");
                    answer = Console.ReadLine();
                }
                
                outputFile.Close();
            }

            catch
            {
                Console.WriteLine("File Read Error");
            }
        }
    }
}
