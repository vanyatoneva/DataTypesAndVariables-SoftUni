using System;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String digits = Console.ReadLine();
            int numOfDigits = digits.Length;
            int num = int.Parse(digits);
            int sumOfDigits = 0;

            for (int i = numOfDigits - 1; i >= 0; i--)
            {
                int d = 1;
                for(int j = 0; j < i ; j++)
                {
                    d *= 10;
                }
                sumOfDigits += num / d;
                num %= d;
            }

            Console.WriteLine(sumOfDigits);
        }
    }
}
