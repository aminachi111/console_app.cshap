using System;

namespace Exam2
{
    class Exam
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            if (num == 0)
            {
                Console.WriteLine("Factorial of 0 is 1");
            }
            else
            {
                for (int i = num; i > 0; i--)
                {
                    fact *= i;
                }
                Console.WriteLine("Factorial of {0} is: {1}", num, fact);
            }
            Console.ReadKey();
        }
    }
}