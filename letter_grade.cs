using System;

namespace Exam1
{
    class Exam
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your numerical score: ");

            double score = Convert.ToDouble(Console.ReadLine());
            string result;
            result = score >= 100 ? "Invalid" :
                score >= 90 ? "A":
                score >= 80 ? "B" :
                score >= 70 ? "C" :
                score >= 60 ? "D" :
                score >= 0 ? "E" : "Invalid";
            Console.WriteLine("Your letter grade is: {0}", result);
            Console.ReadKey();

        }
    }
}