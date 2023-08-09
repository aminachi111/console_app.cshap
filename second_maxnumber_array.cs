using System;

namespace second_maxnumber_array
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

            int max_index = 0;
            for (int i = 1;i < number.Length; i++)
            {
                if (number[i] > max_index)
                {
                    max_index = i;
                }
            }

            int temp = number[max_index];
            number[max_index] = number[number.Length - 1];
            number[number.Length - 1] = temp;

            int[] newnumber = new int[number.Length - 1];

            int second_max = number[0];
            for (int i = 1; i < newnumber.Length; i++)
            {
                if ((number[i] > second_max))
                {
                    second_max = number[i];
                }
            }

            Console.WriteLine("The second biggest number in array: {0}", second_max);
            Console.ReadKey();

        }
    }
}