using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndCasting
{
    internal class Task08
    {
        public static void ParseInput2()
        {
            Console.Write("Please input an integer: ");
            int userInputInteger = int.Parse(Console.ReadLine());

            Console.Write("Please input a decimal number: ");
            decimal userInputDecimal = decimal.Parse(Console.ReadLine());
            decimal divisionOutput = userInputInteger / userInputDecimal;
           

            Console.Write("Would you like the output to be an Char array? Please enter True or False: ");
            bool isCharArr = bool.Parse(Console.ReadLine());

            if(isCharArr)
            {
                char[] results = divisionOutput.ToString().ToCharArray();
                Console.WriteLine(String.Join(", ", results));
                //foreach (char result in results)
                //{
                //    Console.WriteLine(result);
          
                //}
            }
            else
            {
                Console.WriteLine(divisionOutput);
            }


        }
    }
}
