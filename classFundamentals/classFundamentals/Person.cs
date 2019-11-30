using System;
using System.Collections.Generic;

namespace ClassFundamentals
{   
     class Person // struct Person
     {
        public string FirstName;
        public string LastName;
        public List<Order> Orders;

        public void introduce()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
     }

}
