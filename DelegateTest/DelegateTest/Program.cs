using System;

using DelegateTest;

namespace DelegateTest
{
    class Program
    {
        public delegate void delFunc(int x);
        //delegate (int x) { };


        public void squareFunc(int x)
        {
             Console.WriteLine((x * x));
        }

        public void doubleFunc(int x)
        {
            Console.WriteLine((x + x));
        }

        public void delegatePass(delFunc del)
        {
            del(3);
        }

        public void delegateAnonymous( )
        {

        }

        static void Main(string[] args)
        {
            Program p = new Program();     
            delFunc del = p.squareFunc;

            p.squareFunc(3);
            del(4);
            p.delegatePass(p.squareFunc);

            del += p.doubleFunc;
            del(5);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
