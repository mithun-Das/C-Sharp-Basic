using System;

namespace ClassFundamentals
{
    public class A
    {
        private int x = 10;
        protected int y = 20;
    }

    public class NestedClass : A
    {
     
        public static void Main(string[] args)
        {
            A a = new A();
            NestedClass b = new NestedClass();
            //  Console.WriteLine(a.x);  // Think why wrong
            //  Console.WriteLine(b.x);  // Think why wrong
            // Console.WriteLine(a.y);  // Think why wrong
            Console.WriteLine(b.y);
        }

        public void methodA()
        {                           // Think why wrong
          //  public class A
           // {

            //}

        }
    }
}
