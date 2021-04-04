using System;

namespace _3._4_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calls int version of Add()
            Console.WriteLine(Add(10, 10));
            // Calls long version of Add()
            Console.WriteLine(Add(900_000_000_000, 900_000_000_000));
            // Calls double version of Add()
            Console.WriteLine(Add(4.3, 4.4));
            Console.ReadLine();
        }
        // Overloaded Add() method.
        static int Add(int x, int y)
        { return x + y; }
        static double Add(double x, double y)
        { return x + y; }
        static long Add(long x, long y)
        { return x + y; }
    }
}
