using System;

namespace twoxtwo_array
{
    class Task
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 3] { { 0, 2, 4 }, { 6, 8, 10 }, { 1, 3, 5 }, { 7, 9, 11 } };
            Console.WriteLine("array[0, 0] = " + array[0, 0]);
            Console.WriteLine("array[0, 1] = " + array[0, 1]);
            Console.WriteLine("array[0, 2] = " + array[0, 2]);
            Console.WriteLine("array[1, 0] = " + array[1, 0]);
            Console.WriteLine("array[1, 1] = " + array[1, 1]);
            Console.WriteLine("array[1, 2] = " + array[1, 2]);
            Console.WriteLine("array[2, 0] = " + array[2, 0]);
            Console.WriteLine("array[2, 1] = " + array[2, 1]);
            Console.WriteLine("array[2, 2] = " + array[2, 2]);
            Console.WriteLine("array[3, 0] = " + array[3, 0]);
            Console.WriteLine("array[3, 1] = " + array[3, 1]);
            Console.WriteLine("array[3, 2] = " + array[3, 2]);

            Console.ReadKey();
        }
    }
}