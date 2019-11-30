using System;
using System.Collections.Generic;
using ClassFundamentals.Math;
//using HelloWorld;

namespace ClassFundamentals
{
    class Program
    {
        public class NestedClass
        {
          //  public void nestedMethod()
          //  {

            //    Console.WriteLine("Nested Method");
           // }
        }

        //static void Main(string[] args)
        //{
        //    var random = new Random();

        //    for (int i = 0; i < 10; ++i)
        //    {
        //        Console.WriteLine(random.Next());
        //        Console.WriteLine(random.Next(1,10));
        //    }

        //    Person person = new Person();
        //    person.FirstName = "Mithun";
        //    person.LastName = "Das";
        //    person.introduce();

            //   var order = new Order();    // System Crush.............   Think Why
            //  person.Orders.Add(order);


            //  Calculator calculator = new Calculator(); // Think why wrong
            //   calculator.Add(1,2);
            //   Calculator.DisplayNumber(2);

            //var initializeTest = new ObjectInitializer   // Onject Initializer
            //{
            //    firstName = "Mithun",
            //    lastName = "Das"
            //};

            //initializeTest.namePrint();

            
        //}
    }

    public class ObjectInitializer
    {
        //var  firstName;
        //var  lastName;

       public string firstName;
       public string lastName;

        public void namePrint()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
