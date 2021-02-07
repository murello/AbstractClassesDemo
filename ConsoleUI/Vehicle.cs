using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }

        public string Year { get; set; } = "No Year";
        public string Make { get; set; } = "Generic Manufacturer";
        public string Model { get; set; } = "Generic Model";
        public int NumberOfTires { get; set; }


        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"I'm virtually driving my vehicle.");
        }
        
    }

}
