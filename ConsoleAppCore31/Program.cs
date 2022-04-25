using System;
using ClassLibraryMultiTarget;

namespace ConsoleAppCore31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prints: "netcoreapp3.1"
            Console.WriteLine(Class1.TargetFramework);
        }
    }
}
