using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FactoryPatterns
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 1:
                    return new Car();
                case 2:
                    return new Boat();
                case 3:
                    return new Plane();
                default:
                    return new Car();
            }
        }
     
    }
        
        //DONECreate a static VehicleFactory class:
        //Add a GetVehicle method that will return an IVehicle based on the amount of tires it’s given as a parameter:
        //DONE Make the method static
        //A return type of IVehicle
        //1 string parameter
        //Call this method in your Main method
}
