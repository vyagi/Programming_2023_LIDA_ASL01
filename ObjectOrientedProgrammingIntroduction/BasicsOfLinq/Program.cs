using System;
using System.Linq;

namespace BasicsOfLinq
{
    class Program
    { 
        static void Main(string[] args)
        {
            var heights = new int[] { 178, 181, 190, 165, 155, 178, 182, 181, 182, 165, 165 };
            var names = new string[] {"James Bond", "Andrzej Duda",
                "Charlie Chaplin", "Robert Downey Jr.", "John Bean", "Romario" };

            var maxHeight = heights.Max();
            var minHeight = heights.Min();
            var sumOfHeights = heights.Sum();
            var averageHeight = heights.Average();
            var howMany = heights.Count();

            var tallPeople = heights.Where(x => x > 180);
            var theyHave5AtTheEnd = heights.Where(x => x % 10 == 5);

            var fromTallestToShortest = heights.OrderByDescending(x => x);
            
            var properNames = names.Where(x => x.Split(" ").Length == 2);
            var namesWithAInside = names.Where(x => x.Contains("a"));
            var namesFromLongestToShortest = names.OrderBy(x => x.Length);

            var xxxx = names
                .OrderBy(x => x.Split(" ").Length)
                .ThenBy(x => x)
                .Select(x => x.Replace(" ", "").Replace(".", "").ToLower())
                .Where(x => x.Length < 10)
                .Skip(1)
                .Take(2);

            var yyy = heights
                .Where(x => x < 190)
                .OrderByDescending(x=>x)
                .First();
            
            //Console.WriteLine(yyy);

            //foreach (var item in xxxx)
            //{
            //    Console.WriteLine(item);
            //}

            var groupedHeights = heights.GroupBy(x => x / 10);

            foreach (var item in groupedHeights.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key * 10} ({item.Count()} elements)");
                foreach (var height in item.OrderBy(x=>x))
                {
                    Console.WriteLine($"\t{height}");
                }
            }                        
        }
    }
}
