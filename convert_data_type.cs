using System;

namespace Backend5
{
    class Convertion
    {
        static void Main(string[] arg)
        {
            //int to double
            int a;
            a = 5;
            double a1 = a;
            Console.WriteLine("Original: {0} Converted: {1}", a, a1);


            //float to int
            float b;
            b = 6;
            int b1 = (int)b;
            Console.WriteLine("Original: {0} Converted: {1}", b, b1);

            //string to int
            string c;
            c = "7";
            int c1 = int.Parse(c);
            Console.WriteLine("Original: {0} Converted: {1}", c, c1);

            //bool to string
            bool d;
            d = false;
            string d1 = d.ToString();
            Console.WriteLine("Original: {0} Converted: {1}",d, d1);


            //double to string
            double f;
            f = 8.5;
            string f1 = f.ToString();
            Console.WriteLine("Original: {0} Converted: {1}", f, f1);


        }
    }
}