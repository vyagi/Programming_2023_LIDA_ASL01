using System;

namespace Encapsulation
{
    

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("James", "Bond", 40);
            Console.WriteLine($"{s.Name} {s.LastName} is {s.Age}.");

            s.FullName = "Jorge Smith";
            Console.WriteLine($"{s.FullName} is {s.Age}, {s.IsAdult}");
        }
    }
}
