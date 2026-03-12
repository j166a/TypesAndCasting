using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndCasting
{
    internal class Task01
    {
        public static void Run()
        {
            float floatVariable = 3.80f;
            string stringVariable = "h";
            double doubleVariable = 2.5;
            Console.WriteLine(floatVariable);
            Console.WriteLine(stringVariable);
            Console.WriteLine(doubleVariable);
            int myInt = 2;
            decimal ourDecimal = myInt;
            decimal ourDecimal2 = 1.1m;
            double ourDouble = (double)ourDecimal2;
            Console.WriteLine(ourDouble);
            //
            float ourFloat = 2.9f;
            int ourInt = (int)ourFloat;
            Console.WriteLine(ourInt);

            



            
        }
    }
}
