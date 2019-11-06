using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManLibrary
{
    public class TryParse
    {
        public static int IntTryParse()
        {
            string userInput = null;
            int userOutput = 0;

            while (userInput == null)
            {
                Console.Write("Enter a number: > ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out userOutput))
                {
                    return userOutput;
                }
                else
                {
                    userInput = null;
                    Console.WriteLine("Must be a number!");
                }
            }
            return userOutput;
        }

        public static int NewTryParse(string input)
        {
            int num = 0;

            while(!int.TryParse(input, out num))
            {
                Console.WriteLine("Must be a number! > ");
                input = Console.ReadLine();
            }
            return num;
        }
    }
}
