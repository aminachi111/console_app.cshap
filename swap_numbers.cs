using System;

namespace swap_numbers
{
    class Swap
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Orifinal number1 : " + num1);
            Console.WriteLine("Original number2 : " + num2);


            SwapNum(ref num1, ref num2);
            Console.WriteLine("Number1 after swapping : " + num1);
            Console.WriteLine("Number2 after swapping : " + num2);
            Console.ReadLine();
        }
        static void SwapNum(ref int num1,ref int num2)
        {
            int swap = num1;
            num1 = num2;
            num2 = swap;
        }
    }
}