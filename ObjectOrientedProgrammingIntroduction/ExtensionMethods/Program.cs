using System;

namespace ExtensionMethods
{
    public static class StringUtilities
    {
        public static string ToName(this string input)
        {
            return input[0].ToString().ToUpper() + input.Substring(1).ToLower();
        }
    }

    public static class IntUtilities
    {
        public static bool IsPrime(this int input)
        {
            for (int i = 2; i < input; i++)
                if (input % i == 0)
                    return false;

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var name = "maRcIn";//->Marcin
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Contains("rc"));
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Replace("a","B"));

            Console.WriteLine(name.ToName());

            Console.WriteLine(6.IsPrime());
            Console.WriteLine(5.IsPrime());

            DateTime p = new DateTime();
            //HomeWork: p.FirstWeekDayOfYear()
        }
    }
}
