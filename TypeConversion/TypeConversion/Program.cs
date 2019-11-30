using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i = 1;   // Implicit Conversion
            int a = i;

            int y = 1;
            byte b = (byte)y;  // Explicit Conversion

            var number = "1234";
            int z = Convert.ToInt32(number);

            var p = "1Q2P";
            var q = Convert.ToInt32(p);

            //i = "23423";

            try
            {
                var s = "1234";
                var r = Convert.ToByte(s);
                Console.WriteLine(r);
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion Exception !!!");
            }


           // Console.WriteLine(q);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
