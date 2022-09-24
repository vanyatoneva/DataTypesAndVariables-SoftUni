using System;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int remaining = n;
            int targets = 0;

            while(remaining >= m)
            {
                targets++;
                remaining -= m;
                if(remaining != 0 && n / remaining == 2 && n % remaining == 0 && y != 0)
                {
                    remaining /= y;
                }
            }

            Console.WriteLine(remaining);
            Console.WriteLine(targets);
        }
    }
}
