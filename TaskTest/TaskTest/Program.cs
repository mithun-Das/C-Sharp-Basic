using System;
using System.Threading.Tasks;

namespace TaskTest
{
    class Program
    {
        public static void Method1()
        {
            Task t1 = Task.Run(() => {

                for (int i = 0; i <= 100; ++i)
                {
                    Console.WriteLine("Task 1");
                }
            });
        }

        public static void Method2()
        {
            Task t2 = Task.Run(() => {

                for (int i = 0; i <= 100; ++i)
                {
                    Console.WriteLine("Task 2");
                }
            });
        }

        static void Main(string[] args)
        {

            Method1();
            Method2();
            Console.ReadKey();
        }
    }
}
