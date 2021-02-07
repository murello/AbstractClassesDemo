using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle -Done
             * The vehicle class shall have three string properties Year, Make, and Model -Done
             * Set the defaults to something generic in the Vehicle class -Done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation -Done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.-Done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle -Done
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle -Done
             * Provide the implementations for the abstract methods -Done
             * Only in the Motorcycle class will you override the virtual drive method -Done
            */

            // Create a list of Vehicle called vehicles -Done

            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Vehicle car1 = new Car() { Year = "2016", Make = "BMW", Model = "328i", NumberOfTires = 4, NumberOfWindows = 4 };
            Car car2 = new Car() { Year = "1999", Make = "Dodge", Model = "Dakota", NumberOfTires = 4, NumberOfWindows = 2 };
            Motorcycle motor1 = new Motorcycle() { Year = "2019", Make = "Ducati", Model = "Monster", };
            Vehicle motor2 = new Motorcycle();

            //*
               //Add the 4 vehicles to the list -Done
            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motor1);
            vehicles.Add(motor2);







            //* 
            //* Using a foreach loop iterate over each of the properties
            // */

            foreach (var item in vehicles) 
            {
                Console.WriteLine($"{item.Year} { item.Make } {item.Model }" );
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle -Done
            car1.DriveAbstract();
            Console.WriteLine();
            car1.DriveVirtual();
            Console.WriteLine();
            motor1.DriveAbstract();
            Console.WriteLine();
            motor1.DriveVirtual();










            #endregion            
            Console.ReadLine();
        }
    }
}
