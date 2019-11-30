using System;
using System.Threading;
using System.Diagnostics;

namespace ThreadTimeTest
{
    class Program
    {
        public static bool threadFlag1 = false;
        public static bool threadFlag2 = false;
        public static Stopwatch watch = new System.Diagnostics.Stopwatch();

        public static void Method1()
        {
            for (int i = 0; i <= 500000000; ++i)
            {
                if (i == 500000000)
                {
                    Console.WriteLine("Method 1 Completed!!!");
                }
            }
        }

        public static void Method2()
        {
            for (int i = 0; i <= 500000000; ++i)
            {
                if (i == 500000000)
                {
                    Console.WriteLine("Method 2 Completed!!!");
                }
            }
        }

        public static void Thread1()
        {
            for (int i = 0; i <= 500000000; ++i)
            {
                if (i == 500000000)
                {
                    threadFlag1 = true;
                    Console.WriteLine("Thread 1 Completed!!!");

                    if (threadFlag1 && threadFlag2)
                    {
                        watch.Stop();
                        Console.WriteLine("Total Time: " + watch.ElapsedMilliseconds);
                    }

                }
            }
        }

        public static void Thread2()
        {
            for (int i = 0; i <= 500000000; ++i)
            {
                if (i == 500000000)
                {
                    threadFlag2 = true;
                    Console.WriteLine("Thread 2 Completed!!!");

                    if (threadFlag1 && threadFlag2)
                    {
                        watch.Stop();
                        Console.WriteLine("Total Time: " + watch.ElapsedMilliseconds);
                    }

                }
            }
        }



        static void Main(string[] args)
        {
            watch.Start();

            // Method1();
            // Method2();

          //  watch.Stop();
           // Console.WriteLine("Total Time: " + watch.ElapsedMilliseconds);


            //Thread t1 = new Thread( new ThreadStart(Thread1) );
            //Thread t2 = new Thread(new ThreadStart(Thread2));

            // t1.Start();
            // t2.Start();

            // Thread1();
            //  Thread2();
        }
    }
}
