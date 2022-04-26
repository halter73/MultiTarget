using System;
using ClassLibraryMultiTarget;
using ClassLibraryTransitiveSingleTarget;

namespace ConsoleAppCore31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prints: "netcoreapp3.1"
            Console.WriteLine($"{Class1.TargetFramework}, {Class1.MyProperty}, {Class2.MyProperty}");
        }
    }
}
