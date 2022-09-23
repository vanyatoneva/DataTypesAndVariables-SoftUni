using System;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int litres = 255;
            int litresInTank = 0;
           //bool isFull = false;
            int numLines = int.Parse(Console.ReadLine());
            for(int i = 0; i < numLines; i++)
            {
                int currLitres = int.Parse(Console.ReadLine());
                if(currLitres > litres)
                {
                    Console.WriteLine("Insufficient capacity!");
                    //isFull = true;
                    
                }
                else 
                {
                    litres -= currLitres;
                    litresInTank += currLitres;
                }
            }
            Console.WriteLine(litresInTank);
        }
    }
}
