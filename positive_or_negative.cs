using System;

namespace Task
{
    class Calculate
    {
        static void Main(string[] arg)
        {
            Console.Write($"Enter a number: ");
            int a =Convert.ToInt32(Console.ReadLine());
            FindNum(a);

        }
         static void FindNum(int a)
        {
            if (a > 0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }
            else if (a < 0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {a} is neither positive nor negative.");
            }
        }
    }
}