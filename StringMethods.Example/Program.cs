using System;
using Microsoft.SqlServer.Server;

namespace StringMethods.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hw = "Hello, World!";
            Console.WriteLine(hw.Contains("ll"));
            Console.WriteLine(hw.EndsWith("a"));
            Console.WriteLine(hw.IndexOf('o'));
            Console.WriteLine(hw.LastIndexOf('o'));
            string inserted = hw.Insert(0, "C# ");
            Console.WriteLine(inserted);

            string str = "-TEXT-";
            Console.WriteLine(str.PadLeft(10));
            Console.WriteLine(str.PadRight(10));
            Console.WriteLine(str.Remove(2));
            Console.WriteLine(str.Remove(1, 1));
            Console.WriteLine(str.Replace('E', '3'));
            Console.WriteLine(hw.Replace("Hello", "Hi"));
            string[] splitted1 = hw.Split(',');
            string[] splitted2 = hw.Split(',', ' ');
            char[] seperators = { ',', ' ' };
            string[] splitted3 = hw.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(hw.StartsWith("a"));
            Console.WriteLine(hw.Substring(0, 5));
            char[] chars = hw.ToCharArray();

            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Trim('-'));

            Console.WriteLine(string.Join("<->", "a", "b", "c"));
            Console.WriteLine(string.Concat("Hello", "World!"));

            Console.WriteLine(string.IsNullOrEmpty(""));
            Console.WriteLine(string.IsNullOrWhiteSpace("     "));

            // ---

            //Math.Ceiling(2.4); => 3
            //Math.Floor(2.4); => 2
            //Math.Round(2.5, MidpointRounding.AwayFromZero); => 3
            //Math.Pow(2, 4); => 16
            Console.ReadKey();
        }
    }
}
