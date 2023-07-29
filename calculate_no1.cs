using System;

namespace Backend6
{
    class Calculate
    {
        static void Main(string[] arg)
        {
            int x = 24;
            int y = 13;
            int z = (x + y) / 2 + y++ + ++y + 2 * (x-- * 4);
            int w = z++ + (w = y) - --w;
            Console.WriteLine($"{x} {y} {w} {z}");
            Console.ReadLine();
        }
    }
}