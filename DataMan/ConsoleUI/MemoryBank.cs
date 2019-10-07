using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class MemoryBank
    {
        public static void getMemoryBank()
        {
            // Named constants
            const int QUESTION_AMOUNT = 10;

            // Local variables
            Random rand = new Random();
            int num1 = rand.Next(1, 100);
            int num2 = 0;
            char[] operators = { '+', '-', '*', '/' };
            char randomOp = operators[rand.Next(operators.Length)];
            
        }
        

    }
}
