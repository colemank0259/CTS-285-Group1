﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        { 
            bool exit = false;

            do
            {
                Messages.Menu();

                switch (Messages.GetUserInput())
                {
                    case "1":
                        AnswerChecker.GetAnswerChecker();
                        break;
                    case "2":
                        RandomProblem.GetRandomProblem();
                        break;
                    case "3":
                        NumberGuesser.GetNumberGuesser();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Messages.ErrorMessage();
                        break;
                }
            } while (exit == false);
        }
    }
}
