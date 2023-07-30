using System;

namespace factorial_recursive
{
    class task
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of {0} is {1}",num,Factorial(num));
            Console.ReadKey(); 
        }

        static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factorial(num-1);
        }
 
    }
}