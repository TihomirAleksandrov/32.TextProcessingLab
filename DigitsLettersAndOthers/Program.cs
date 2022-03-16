using System;
using System.Linq;

namespace DigitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            string numbers = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;
            
            foreach (char symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    numbers += symbol.ToString();
                }
                else if (char.IsLetter(symbol))
                {
                    letters += symbol.ToString();
                }
                else
                {
                    others += symbol.ToString();
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
