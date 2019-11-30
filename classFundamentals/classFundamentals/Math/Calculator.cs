using System;

namespace ClassFundamentals.Math
{
    class Calculator
    {
        public Calculator(string digitType)
        {
            Console.WriteLine(digitType);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void DisplayNumber(int x)
        {
            Console.WriteLine(x);
        }
    }
}
