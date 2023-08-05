using System;

namespace find_max_array
{
    class Task
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] number = new int[size];

            Console.WriteLine("Enter the elements of the array: ");
            string[] elements = Console.ReadLine().Split(" ");

            for (int i = 0; i < size; i++)
            {
                number[i] = int.Parse(elements[i]);
            }

            int max_array = number[0];
            for (int j = 1; j < size; j++)
            {
                if (number[j] > max_array)
                {
                    max_array = number[j];
                }
            }
            Console.WriteLine("The biggest number in the array: {0}", max_array );
            Console.ReadKey();
        }
    }
}