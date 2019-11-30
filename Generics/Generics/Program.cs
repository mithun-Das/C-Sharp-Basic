using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Generics;

namespace Generics
{
    public delegate T GenericDelegate<T>(T t);

    public class GenericClass<T>
    {
        public GenericClass()
        {

        }

        public T GenericMethod(T t)
        {
            return (t);
        }
    }

    class Program
    {
        static T[] Swap<T>(T t1, T t2) {

            T t = t1;
            t1 = t2;
            t2 = t;

            T[] arr = new T[2];
            arr[0] = t1;
            arr[1] = t2;

            return arr;
        }

        static void Main(string[] args)
        {
            GenericClass<int> test = new GenericClass<int>();

            int x = test.GenericMethod(3);
       
            Console.WriteLine(x);

            GenericClass<string> test1 = new GenericClass<string>();

            string y = test1.GenericMethod("Hello");

            Console.WriteLine(y);

            int[] res = Swap<int>(3,4);

            Console.WriteLine(res[0]);

            int squareMethod(int z)
            {
                return (z * z);
            }

            GenericDelegate<int> genericClass = squareMethod;
            int sqr = genericClass(5);

            Console.WriteLine(sqr);


            Console.ReadKey();


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
