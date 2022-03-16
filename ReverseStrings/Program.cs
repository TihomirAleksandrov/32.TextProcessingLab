using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
               string reverseWord = string.Empty;
                
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseWord += input[i];
                }

                Console.WriteLine($"{input} = {reverseWord}");
            }
        }
    }
}
