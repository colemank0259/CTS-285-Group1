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
            var equations = "equations";
            var answers = "answers";
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText("Parent_Teacher.csv");
                Console.WriteLine("Parent/Teacher please enter your 10 problems and solutions.");
                Console.WriteLine("Example: first enter problem (2+2=)\nThen enter solution (4)");
                for (int entries = 1; entries <= 10; entries ++)
                {
                    var newLine = string.Format($"{equations}, {answers}");

                    outputFile.WriteLine(newLine);

                    Console.Write($"\nEnter Problem Number {entries}! > ");
                    equations = Console.ReadLine();

                    Console.Write($"\nEnter Solution number {entries}! > ");
                    answers =  Console.ReadLine();
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
