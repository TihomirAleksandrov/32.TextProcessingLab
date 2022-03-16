using System;
using System.Linq;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string mainString = Console.ReadLine();

            while (mainString.IndexOf(item) >= 0)
            {
                mainString = mainString.Remove(mainString.IndexOf(item), item.Length);
            }

            Console.WriteLine(mainString);
        }
    }
}
