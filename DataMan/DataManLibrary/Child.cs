using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    public class Child
    {
        public static void GetChildAnswers()
        {
            List<string> answers = new List<string>();

            using (StreamReader fileReader = new StreamReader("Parent_Teacher.csv"))
            {
                fileReader.ReadLine();

                while(!fileReader.EndOfStream)
                {
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');

                    answers.Add(values[0].ToString());
                }

                foreach(string answer in answers)
                {
                    Console.WriteLine(answer);
                }
            }
        }
    }
}
