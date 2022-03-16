using System;
using System.Linq;

namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            string replacement = string.Empty;

            foreach (string word in bannedWords)
            {
                replacement = new string('*', word.Length);
                text = text.Replace(word, replacement);
            }

            Console.WriteLine(text);
        }
    }
}
