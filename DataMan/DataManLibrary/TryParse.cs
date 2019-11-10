using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManLibrary
{
    public class TryParse
    {
        public static int IntTryParse(string input)
        {
            int num = 0;

            while(!int.TryParse(input, out num))
            {
                Console.WriteLine("Must be a number! > ");
                input = Console.ReadLine();
            }
            return num;
        }

        public static double DoubleTryParse(string input)
        {
            double num = 0;

            while(!double.TryParse(input, out num))
            {
                Console.WriteLine("Must be a number! > ");
                input = Console.ReadLine();
            }
            return num;
        }

        public static string SymbolParse(string input)
        {
            while (input != "+" && input != "-" && input != "*" && input != "/")
            {
                Console.Write("Enter an operator: (+, -, *, /) > ");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
