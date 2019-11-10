using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManLibrary
{
    public class Messages
    {
        public static void Menu()       // Method to display menu.
        {
            Console.WriteLine("Welcome to the Dataman program.");
            Console.WriteLine("Please choose from the menu below.");
            Console.WriteLine("1. Answer Checker");
            Console.WriteLine("2. Memory Bank");
            Console.WriteLine("3. Data Bank");
            Console.WriteLine("4. Number Guesser");
            Console.WriteLine("5. Exit");
            Console.Write("> ");
        }

        public static string DataBankMenu()     // Method to display menu for DataBank class.
        {
            Console.WriteLine("\n1. Continue as a Parent/Teacher! (Enter in problems)");
            Console.WriteLine("2. Continue as a Child/Student! (Answer Problems)");
            Console.WriteLine("3. Exit!");
            Console.Write("> ");

            return Console.ReadLine();
        }

        public static string GetUserInput()     // Method to get user input.
        {
            return Console.ReadLine();
        }

        public static void ErrorMessage()       // Method to display error.
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine();
        }
    }
}
