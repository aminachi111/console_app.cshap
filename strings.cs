using System;
using System.Diagnostics.Tracing;


namespace String
{
    class Task
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Console.WriteLine("Uppercase: " + str.ToUpper());
            Console.WriteLine("Lowercase: " + str.ToLower());
            Console.WriteLine("Total characters: " + str.Length);
            Console.WriteLine("First 5 characters: " + str.Substring(0, 5));
            Console.WriteLine("Last 5 characters: " + str.Substring(str.Length - 5,5));
            string character = "a";
            string replace = "*";
            Console.WriteLine("Replace 'a' with '*': " + str.Replace(character, replace));
            string word = "Csharp";
            bool specifiedword = str.Contains(word);
            if (specifiedword)
            {
                Console.WriteLine("Contains '{0}': Yes", word);
            }
            else
            {
                Console.WriteLine("Contains '{0}': No", word);
            }
            Console.WriteLine("Index of e: " + str.IndexOf("e", 0));
            string[] words = str.Split(" ");
            Console.WriteLine("Split the words: ");
            foreach (string word1 in words)
            {
                Console.WriteLine("- {0}",word1);
            }
            Console.ReadKey();

        }


    }
}