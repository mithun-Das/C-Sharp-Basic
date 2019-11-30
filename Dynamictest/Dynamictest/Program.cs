using System;

namespace Dynamictest
{

    class Student
    {
        public int Id;

        public void CalculateResult()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var x = 1;
            //x = "Hello world";

            dynamic y = 1;
            Console.WriteLine(y);

            y = "Hello world !!!";
            Console.WriteLine(y);

            y = true;
            Console.WriteLine(y);

            dynamic obj = new Student();

            //obj.findResult();

            //Program p = new Program();

            Dynamicparam(7);
            Dynamicparam("Success !!!");

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        //static void dynamicParam(var p)
        //{

        //}

        static void Dynamicparam(dynamic p)
        {
            Console.WriteLine(p);
            Console.WriteLine(p);
        }
    }
}
