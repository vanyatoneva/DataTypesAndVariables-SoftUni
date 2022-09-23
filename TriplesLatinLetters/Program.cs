using System;

namespace TriplesLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num += 97;

            for(int i = 97; i < num; i++)
            {
                for(int j = 97; j < num; j++)
                {
                    for(int k = 97; k <  num; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
