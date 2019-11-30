using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "string 1";  // String is object but immutable 
            var str2 = str1;
            str2 = "converted to string 2";
            Console.WriteLine(str1);

            var fullName = " Mithun Das ";
            Console.WriteLine(fullName.Trim());

        }
    }
}
