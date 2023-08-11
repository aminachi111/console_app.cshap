using System;
using System.Drawing;

namespace avg_function_array
{
    class Task
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            string[] elements = Console.ReadLine().Split(" ");

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(elements[i]);
            }

            Console.WriteLine("Average value is: {0}", Average(arr,size));
            Console.ReadKey();
        }

        static double Average(int[] arr,int size)
        {
            int sum = 0;
            foreach ( int i in arr)
            {
                sum += i;
            }

            double avg = (double)sum / size;
            return avg;
        }
    }
}