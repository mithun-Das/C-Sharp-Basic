using System;
using System.Linq;

namespace LinqTest
{
    public class Student
    {
        public int StudentID;
        public string Name;
        public int Roll;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mithun" , "Nitu", "Munni", "Mridul", "Abha"};

            var filterQuery = from name in names where name.Contains('a') select name;
            Console.WriteLine(filterQuery);

            foreach (var name in filterQuery)
            {
               // Console.WriteLine(name);
            }

            Student[] stdArray =
            {
                new Student() { StudentID = 1, Name = "Mithun", Roll = 1 },
                new Student() { StudentID = 2, Name = "Atish", Roll = 2 },
                new Student() { StudentID = 3, Name = "Dipanakr", Roll = 3 },
                new Student() { StudentID = 4, Name = "Barun", Roll = 4 },
                new Student() { StudentID = 5, Name = "Mohesh", Roll = 5 },
                new Student() { StudentID = 6, Name = "Arun", Roll = 6 },
                new Student() { StudentID = 7, Name = "Chandan", Roll = 7 }
            };

            Student[] rankStudent = stdArray.Where(s => s.Roll >= 1 && s.Roll <= 3).ToArray();

            foreach (Student std in rankStudent)
            {
                Console.WriteLine(std.Name);
            }

            Student[] selectedIdStudent = stdArray.Where( s => true ).ToArray();

            foreach (Student std in selectedIdStudent)
            {
                Console.WriteLine(std.Name);
            }
        }
    }
}
