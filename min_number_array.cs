using System;

namespace min_number_array
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

            int min_array = number[0];
            for (int j = 1;  j < size; j++) 
            { 
                if (number[j] < min_array)
                {
                    min_array = number[j];
                }
            }
            Console.WriteLine("The min number of the array: {0}", min_array);
            Console.ReadKey();
        }
    }
}