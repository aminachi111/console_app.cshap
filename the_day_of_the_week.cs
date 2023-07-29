using System;

namespace Task1
{
    class Calculate
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-7): ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Output: Monday");
                    break;
                case 2:
                    Console.WriteLine("Output: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Output: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Output: Thursday");
                    break;
                case 5:
                    Console.WriteLine("Output: Friday");
                    break;
                case 6:
                    Console.WriteLine("Output: Saturday");
                    break;
                case 7:
                    Console.WriteLine("Output: Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input.Please enter a number between 1 and 7.");
                    break;


            }

        }

       
    }
}