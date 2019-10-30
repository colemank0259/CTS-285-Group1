using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class DataBank
    {
        public static void CreateDataBank()
        {
            bool exit = false;

            do
            {
                switch(Messages.DataBankMenu())
                {
                    case "1":
                        //TODO Parent
                        break;
                    case "2":
                        //TODO Child
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
