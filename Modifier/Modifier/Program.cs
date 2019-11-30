using System;

namespace Modifier
{
    class Program
    {
        public readonly static int year = 9;
        public const  int age = 19;

        public Program()
        {
            year = 4;
            //age = 10;   //  Compile Error
        }

        public static void refModifierTest(ref int a,int b,out int c)
        {
            a += 1;
            b += 1;
            c = 1;
        }

        public static void paramsModifierTest(params int[] data)
        {

            for (int j = 0; j < 2; ++j)
            {
                data[j] = data[j] + 1;
            }

        }

        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z;

            refModifierTest(ref x,y,out z);  // Without static it will not run
            Console.WriteLine("X : " + x + " y : " + y + " Z : " + z);

            paramsModifierTest(1,2,3);

            // year = 10;     //  Compile Error





        }
    }
}
