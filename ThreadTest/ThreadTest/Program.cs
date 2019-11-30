using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program
    {
        public static void Method1()
        {
            for (int i = 0; i <= 100; ++i)
            {
                Console.WriteLine("Mehtod 1 : {0}", i);
            }
        }

        public static void Method2()
        {
            for (int i = 0; i <= 100; ++i)
            {
                Console.WriteLine("Mehtod 2 : {0}", i);
            }
        }

        public static void Task1()
        {

            Task.Run( () => {

                for (int i = 0; i <= 100; ++i)
                {
                    Console.WriteLine("Task 1 : {0}", i);
                }
            });
        }

        public static void Task2()
        {
            Task.Run(() => {

                for (int i = 0; i <= 100; ++i)
                {
                    Console.WriteLine("Task 2 : {0}", i);
                }
            });
        }

        public static void Thread1()
        {
            Thread t = new Thread( new ThreadStart(ThreadProc1));
            t.Start();
        }

        public static void Thread2()
        {
            Thread t = new Thread(new ThreadStart(ThreadProc2));
            t.Start();
        }



        public static void ThreadProc1()
        {
            for (int i = 0; i <= 100; ++i)
            {
                Console.WriteLine("Thread 1: " + i);
                //Thread.Sleep(0);
            }
        }

        public static void ThreadProc2()
        {
            for (int i = 0; i <= 100; ++i)
            {
                Console.WriteLine("Thread 2: " + i);
                //Thread.Sleep(0);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Main thread: Start a second thread.");

            //Thread t = new Thread( new ThreadStart(ThreadProc) );
             Method1();
             Method2();
           //   Task1();
           //   Task2();
           // Thread1();
           // Thread2();

            //t.Start();

            // for (int i = 0; i <= 4; ++i)
            //{
            //   Console.WriteLine("In main thread");
            //Thread.Sleep(1);
            //}


            Console.WriteLine("Main thread: Call Join(), to wait until ThreadProc ends.");
           // t.Join();
            Console.WriteLine("Main thread: ThreadProc.Join has returned.  Press Enter to end program.");
            Console.ReadLine();
        }
    }
}
