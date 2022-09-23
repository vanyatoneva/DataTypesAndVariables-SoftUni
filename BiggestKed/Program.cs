using System;

namespace BiggestKed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsNum = int.Parse(Console.ReadLine());
            double maxVolume = 0.00;
            String biggestModel = "";

            for(int i = 0; i < kegsNum; i++)
            {
                String model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = (3.14 * radius * radius * height);
                if(volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestModel = model;
                }
            }

            Console.WriteLine(biggestModel);
        }
    }
}
