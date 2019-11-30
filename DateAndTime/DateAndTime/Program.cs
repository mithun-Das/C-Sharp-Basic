using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

           // Console.WriteLine(now);
          //  Console.WriteLine(now.Minute);
           // Console.WriteLine(today);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

           // Console.WriteLine(now.ToLongDateString());
           // Console.WriteLine(now.ToShortDateString());
           // Console.WriteLine(now.ToLongTimeString());
           // Console.WriteLine(now.ToShortTimeString());
           // Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(180);
            var duration = end - start;
          //  Console.WriteLine("Duration" + duration);
          // Console.WriteLine(duration.TotalHours);

            Console.WriteLine("Add Example : " + duration.Add(TimeSpan.FromMinutes(130)));
            Console.WriteLine("Subtract Example : " + duration.Subtract(TimeSpan.FromMinutes(190)));


            var todayForTest = DateTime.Now;
            Console.WriteLine(todayForTest);
            var testDate = todayForTest;
            testDate = testDate.AddDays(1);
            Console.WriteLine(testDate);
            Console.WriteLine(todayForTest);
        }
    }
}
