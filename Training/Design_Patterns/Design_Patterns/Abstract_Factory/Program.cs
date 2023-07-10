using Abstract_Factory;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle_Family_Factory factory = new Bike_Family_Factory();


            Vehicle_Factory carFactory = factory.CreateCarFactory();
            Vehicle_Factory bikeFactory = factory.CreateBikeFactory();

            Vehicle car = carFactory.CreateVehicle();
            Vehicle bike = bikeFactory.CreateVehicle();

            car.Drive();
            bike.Drive();
            
        }
    }
}