using System;

namespace HackerRank.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dotnetVer = "?";
#if NET7_0
            dotnetVer = ".NET 7";
#elif NET6_0
            dotnetVer = ".NET 6";
#elif NET5_0
            dotnetVer = ".NET 5";
#else
            dotnetVer = "lower than .NET 5";
#endif
            Console.WriteLine($"Target framework: {dotnetVer}\n");
            Console.WriteLine("Hello, HackerRankers!");
        }
    }
}
