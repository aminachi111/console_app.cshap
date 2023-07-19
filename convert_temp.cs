using System;

namespace Backend3
{
    class Temperature
    {
        static void Main(string[] args)
        {
            /* my first program in C# */
            Console.Write("Enter the temperature in Celsius: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("The temperature in Fahrenheit: ");
            Console.WriteLine(ConvertTemp(a));
            Console.ReadKey();
            
        }
        static int ConvertTemp(int a)
        {
            return (a * 9 / 5) + 32;
        }
    }
   
}