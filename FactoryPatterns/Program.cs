using System;
using System.Runtime.ConstrainedExecution;

namespace FactoryPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetVehicle method that will return an IVehicle based on the amount of tires it’s given as a parameter:
            //Make the method static
            //A return type of IVehicle
            //1 string parameter
            //Call this method in your Main method

            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Please enter your agent identification name:");
                string agentName = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Hello, " + agentName + ". What kind of vehicle are you going to need for your mission: 1) land 2) sea 3) air");
                input = int.TryParse(Console.ReadLine(), out wheelCount);
                Console.WriteLine();

                Console.WriteLine("This message will self destruct upon delivery");
                Console.WriteLine();

            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
            
            
            //if (userVehicle.ToLower() == "land")
            //{
            //    Car car = new Car();
            //    car.Drive();
            //    Console.ReadLine();

            //}
            //else if (userVehicle.ToLower() == "sea")
            //{
            //    Boat boat = new Boat();
            //    boat.Drive();
            //    Console.ReadLine();
            //}
            //else if (userVehicle.ToLower() == "air")
            //{
            //    Plane plane = new Plane();
            //    plane.Drive();
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            



        }
    }
}
