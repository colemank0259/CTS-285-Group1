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
            List<string> equations = new List<string>();
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
        }
    }
}
