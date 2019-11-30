using System;

namespace InterfaceClass
{
    class InterfaceClassTest
    {
        public interface  ChildClass
        {
            // events, indexers, methods, and properties.

            // private int x;      // Think why wrong
            // protected int y;    // Think why wrong
            // int x;              // Think why wrong 

            //public void childmethod();  // Think why wrong

              void childMethod();


        }

        public interface ParentClass : ChildClass
        {

            void parentMethod();
        }

         class MainClass : ParentClass
         {
            public void childMethod()
            {
                Console.WriteLine("Inside ChildMethod!");
            }

            public void parentMethod()
            {
                Console.WriteLine("Inside ParentMethod!");
            }

            public void mainMethod()
            {
                Console.WriteLine("Hello World!");
            }
         }

        static void Main(string[] args)
        {
            MainClass m = new MainClass();
            m.mainMethod();
            m.parentMethod();
            m.childMethod();

        }
    }
}
