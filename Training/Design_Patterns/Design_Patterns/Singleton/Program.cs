


using Singleton;

Vehicle_Factory vehicle_Factory = Vehicle_Factory.Instance;
Vehicle_Factory vehicle_Factory2 = Vehicle_Factory.Instance;


Vehicle car1 = vehicle_Factory.createVehicle("car");
Vehicle bike1 = vehicle_Factory.createVehicle("Bike");

car1.Drive();
bike1.Drive();

Vehicle car2 = vehicle_Factory.createVehicle("car");
Vehicle bike2 = vehicle_Factory.createVehicle("Bike");

car2.Drive();
bike2.Drive();

