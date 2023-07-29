using System;

namespace Backend7
{
    class Program
    {
        static void Main(string[] arg)
        {
            int a = 3;
            int b = 5;
            int c = 7;
            int d = 2;
            int e = 4;

            int result = a++ + --b * c - e-- + ++d / a + b-- * c / e;

            Console.WriteLine("Initial values:");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"d: {d}");
            Console.WriteLine($"e: {e}");
            

            Console.WriteLine("\nExpresion Result");
            Console.WriteLine($"result = a++ + --b * c - e-- + ++d / a + b-- * c / e = {result}");
        }
    }
}