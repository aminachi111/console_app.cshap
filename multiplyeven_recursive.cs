using System;

namespace multiplyeven_recursive
{
    class Task
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer for " + num + " is " + Multiply(num));
            Console.ReadKey();
        }

        static int Multiply(int num)
        {
            if (num <= 1)
            {
                return 0;
            }
            else if (num == 2)
            {
                return 2;
            }
            else
            {
                if ((num % 2) != 0)
                {
                    num -= 1;
                    return num * Multiply(num - 2);
                }
                else
                {
                    return num * Multiply(num - 2);
                }
            } 
        }
    }
}