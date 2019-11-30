using System;

namespace ExtensionMethods
{
    public static class IntExtension
    {
        public static bool IsGreaterThan(this int x, int y)
        {

            return x > y;

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public static int doublemaker(this int x)
        {
            return (x * 2);
        }

        public static int trippleMaker()
        {
            return 30;
        }

        public static int Singleincrement(this int x)
        {
            return ++x ;
        }

    }
}
