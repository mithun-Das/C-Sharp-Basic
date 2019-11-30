using System;

using Event;

namespace Event
{
    class Subscriber
    {
        public void showNumber(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Main(string[] args)
        {
            Event publisher = new Event();
            Subscriber subscriber = new Subscriber();

            publisher.eventPublisher += subscriber.showNumber; // remarkable

            Console.WriteLine(publisher.printNumber("Event 1"));
            Console.WriteLine(publisher.printNumber("Event 2"));
            Console.ReadKey();

        }
    }
}
