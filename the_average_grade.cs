using System;

namespace Backend4
{
    class Score
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the score for subject 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the score for subject 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the score for subject 3: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("The average grade is: ");
            Console.WriteLine(Aver(a,b,c));
            Console.ReadKey();

        }

        static double Aver(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
    }
}
