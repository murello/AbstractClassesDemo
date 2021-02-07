using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            NumberOfTires = 2;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} which is a {GetType().BaseType.Name} in a abstract method.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("I'm virtually driving my vehicle.");
        }
    }
}
