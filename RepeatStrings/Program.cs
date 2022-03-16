using System;
using System.Linq;

namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string finalText = string.Empty;
            
            foreach (string inputString in input)
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    finalText += inputString;
                }
            }
            
            Console.WriteLine(finalText);
        }
    }
}
