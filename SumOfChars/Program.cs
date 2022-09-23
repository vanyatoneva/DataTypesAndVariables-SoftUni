using System;

namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int ascii = 0;
            for(int i = 0; i < lines; i++)
            {
                Char c = char.Parse(Console.ReadLine());
                ascii += c;
            }
            Console.WriteLine($"The sum equals: {ascii}");
        }
    }
}
