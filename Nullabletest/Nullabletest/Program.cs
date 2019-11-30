using System;


namespace Nullabletest
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> x = null;

            int? y = null;
            int z = x ?? 0;

            x = 3;

            if(x > y)
            {
                Console.WriteLine("x > y");
            }
            
            if(Nullable.Compare<int>(x,y) < 0)
            {
                Console.WriteLine(" x > y");
            }
            else if(Nullable.Compare<int>(x,y) > 0)
            {
                Console.WriteLine(" x < y");
            }


            //int y = null;

            Console.WriteLine(x.Value);
            Console.WriteLine(y.GetValueOrDefault());

            if (y.HasValue)
            {
                Console.WriteLine("Y contains value");
            }

            Console.ReadKey();
        }
    }
}
