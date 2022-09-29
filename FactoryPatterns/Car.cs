using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    internal class Car : IVehicle
    {
        //Create 2 new public classes that will conform to IVehicle:
        //Examples: Car, Truck, Motorcycle, BigRig,  SUV
        //These 2 classes must implement the Drive method
        public Car()
        {
        }
        
        public void Drive()
        {
            Console.WriteLine("Your car is being delivered momentarily");
        }
    }
}
