using Factory;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double abstraction
            Vehicle_Factory carfactory = new Car_Factory();
            Vehicle_Factory bikefactory = new Bike_Factory();

            //
            Vehicle car = carfactory.CreateVehicle();
            Vehicle bike = bikefactory.CreateVehicle();

            car.Drive();
            bike.Drive();
        }
    }
}