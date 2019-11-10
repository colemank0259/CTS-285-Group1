using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManLibrary
{
    public class DataBank
    {
        public static void GetDataBank()
        {
            bool exit = false;

            do
            {
                switch(Messages.DataBankMenu())     // Run a method based on user input.
                {
                    case "1":
                        Parent.GetParentEntry();
                        break;
                    case "2":
                        Child.GetChildAnswers();
                        break;
                    case "3":
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
