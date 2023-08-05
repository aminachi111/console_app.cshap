using System;

namespace sumeven_array
{
    class Task
    {
        static void Main()
        {

            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("Enter the elements of the array: ");
            string[] elements = Console.ReadLine().Split(' ');

            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(elements[i]);
            }

            int sum = 0;
            for ( int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    sum += numbers[j];
                }
            }
            Console.WriteLine("The sum of even numbers in this array: {0}", sum);
            Console.ReadKey();
        }
    }
}