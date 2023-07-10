using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //sealed used -> not to use any class(privacy within a family)
    public sealed class Vehicle_Factory
    {
        //only one time
        private static Vehicle_Factory? instance;
        public static Vehicle_Factory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Vehicle_Factory();
                }
                return instance;
            }
        }
        public  Vehicle createVehicle(string name)
        {
            switch(name.ToLower()) 
            {
                case "car":
                    return new Car();
                case "Bike":
                    return new Bike();

                default:
                    throw new ArgumentException($"Invalid vehivle type:{name}");
                    
            }
        }
    }
}
