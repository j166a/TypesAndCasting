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

            //Implicit conversion from int to decimal

            int myInt = 2;
            decimal ourDecimal = myInt;

            //Explicit conversion from decimal to double

            decimal ourDecimal2 = 1.1m;
            double ourDouble = (double)ourDecimal2;
            Console.WriteLine(ourDouble);

            //Explicit conversion from float to int

            float ourFloat = 2.9f;
            int ourInt = (int)ourFloat;
            Console.WriteLine(ourInt);

            //Explicit conversion from float to decimal
            decimal ourDecimal3 = (decimal)ourFloat;
            Console.WriteLine(ourDecimal3);

            //Explicit conversion from double to flaot 
            double ourDouble2 = 3.678908765436578;
            float ourFloat1 = (float)ourDouble2;
            Console.WriteLine(ourFloat1);







        }
    }
}
