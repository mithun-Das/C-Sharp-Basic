using System;

using ExtensionMethods;

namespace ExtensionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int x = 10;
            int y = 1;

            if (x.IsGreaterThan(y))
            {
                Console.WriteLine(" x > y");
            }
            else
            {
                Console.WriteLine(" x < y");
            }

            Console.WriteLine(x.doublemaker());
           // Console.WriteLine(x.trippleMaker());
            Console.WriteLine(x.Singleincrement());

            Console.ReadKey();
        }
    }
}
