using System;
using System.Collections.Generic;

namespace Variables
{
    class Program
    {
        public enum indicator
        {
            firstIndicator = 1,
            secondIndicator = 2,
            thirdIndicator = 3
        }

        static void Main(string[] args)
        {
            /*
              primitive types are structure but strings  are class
             */

            byte number = 2;  
            int count = 10;
            float totalPrice = 20.85f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;

            var varNumber = 2;
            var varCount = 10;
            var varTotalPrice = 20.85f;
            var varCharacter = 'A';
            var varFirstName = "Mosh";
            var varIsWorking = false;

            //varNumber = "test";
            firstName = "qwqw";
           // firstName[0] = 'n';

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);  
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);


            var methodId = 6;
            Console.WriteLine((indicator)methodId);
            Console.WriteLine(indicator.firstIndicator);

            var method = indicator.thirdIndicator;
            Console.WriteLine(method.ToString());

            var numberList = new List<int>() { 1, 2, 3 };
            numberList.Add(4);
            numberList.AddRange(new int[3] { 5,6,7 });

            foreach (var numberValue in numberList)
            {
                Console.WriteLine(numberValue);
            }

        }
    }
}
