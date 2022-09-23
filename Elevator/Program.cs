using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int personsPerElevator = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numPeople / personsPerElevator);

            Console.WriteLine(courses);
        }
    }
}
