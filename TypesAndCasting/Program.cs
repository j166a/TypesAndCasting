namespace TypesAndCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task00.Run();
            Task01.Run();


            //Task04
            double num1 = 2.2;
            decimal num2 = 4.9m;
            
            int result = Task04.MultiplyInt((int)num1, (int)num2);
            Console.WriteLine(result);

            ////Task05
            //Task05.ParseInput();

            ////Task07
            //Task07.Run();

            Task08.ParseInput2();

        }
    }
}
