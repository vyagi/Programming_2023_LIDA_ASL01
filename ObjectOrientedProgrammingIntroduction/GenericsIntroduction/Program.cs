using System;

namespace GenericsIntroduction
{
    class Pair<T1, T2>
    {
        public T1 First;
        public T2 Second;

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pair<int, int>(1, 5);
            Console.WriteLine($"{p1.First}, {p1.Second}");

            var p2 = new Pair<string, string>("James", "Bond");
            Console.WriteLine($"{p2.First}, {p2.Second}");

            var p3 = new Pair<DateTime, DateTime>(new DateTime(), DateTime.Now);
            Console.WriteLine($"{p3.First}, {p3.Second}");
        }
    }
}
