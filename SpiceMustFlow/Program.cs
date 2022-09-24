using System;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            ulong extractedSpices = 0;

            while(yield >= 100)
            {
                days++;
                extractedSpices += (ulong)yield - 26;
                if(extractedSpices < 0)
                {
                    extractedSpices = 0;
                }
                yield -= 10;
            }

            if (extractedSpices >= 26)
            {
                extractedSpices -= 26; //workers get 26 more when ready
            }
            else
            {
                extractedSpices = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(extractedSpices);
        }
    }
}
