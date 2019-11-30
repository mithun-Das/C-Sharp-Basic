using System;

namespace CustomException
{
    class NumberRangeException : Exception
    {
        public NumberRangeException()
        {

        }

        public NumberRangeException(int num)
            : base("Number is out of Range " + num)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 100; ++i)
            {
                try
                {
                    int x = int.Parse(Console.ReadLine());

                    if (x > 100)
                    {
                        throw new NumberRangeException(x);
                    }
                }
                catch (NumberRangeException ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }
    }
}
