using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var heights = new int[] { 180, 178, 185, 192, 180, 174, 180, 174, 191, 192, 182 };
            var names = new string[] { "James Bond", "John Rambo", "Mr Bean", "Janko Walski", "Romario", "Robert Downey Jr." };
            
            //var max = heights.Max();
            //Console.WriteLine(max);
            //Console.WriteLine(heights.Min());
            //Console.WriteLine(heights.Sum());
            //Console.WriteLine(heights.Count());
            //Console.WriteLine(heights.Average());

            var basketballPlayers = heights.Where(x => x > 180);
            Display(basketballPlayers);

            var fromLowestToHighest = heights.OrderBy(x => x);
            Display(fromLowestToHighest);

            var fancyThing = names
                .Where(x => x.Contains(" "))
                .OrderByDescending(x => x.Length)
                .Select(x => x.Replace(" ", "").ToLower())
                .Take(3);

            Display(fancyThing);
        }

        static void Display<T>(IEnumerable<T> input)
        {
            Console.WriteLine("***************");
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
