using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndCasting
{
    internal class Task07
    {
        public static void Run()
        {
            Fruit myFruit1 = new Fruit();
            Fruit myFruit2 = new Fruit();
            Fruit fruit1Copy = myFruit1;
            myFruit1.Speak();
            //Console.WriteLine(fruit1Copy == myFruit1);
            //Console.WriteLine(myFruit1.GetType());
            //Console.WriteLine(ReferenceEquals(myFruit1, fruit1Copy));
            //Console.WriteLine(myFruit1.GetHashCode());
            //Console.WriteLine(myFruit2.ToString());
            Console.WriteLine(Equals(myFruit1, myFruit2));
        }
    }

    public class Fruit
    {
        public string Name;
        public void Speak()
        {
            Console.WriteLine("Hello I am a Fruit");
        }

    }

}
