using System;

namespace Task3
{
    class task
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            if (num <= 1)
            {
                Console.WriteLine("Answer is 0");
            }
            else
            {
                for (int i = 2; i <= num; i+=2)
                {
                    b *= i;
                }
                Console.WriteLine("Answer is : {0}", b);
            }
        }
    }
}