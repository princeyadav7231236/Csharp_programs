using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covarience_in_Delegates
{
    class Vehicle
    {
        public Vehicle createVehicle()
        {
            Vehicle MyVehicle = new Vehicle();
            Console.WriteLine("Inside Vehicle.createVehicle, a vehicle object is created. ");
            return MyVehicle;
        }
    }
    class Bus : Vehicle
    {
        public Bus createBus()
        {
            Bus MyBus = new Bus();
            Console.WriteLine("Inside Bus.createBus, a Bus object is created. ");
            return MyBus;
        }
    }
    
    class Program
    {
        public delegate Vehicle VehicleDelegate();
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Bus bus = new Bus();
            /* VehicleDelegate is expecting a method with return type Vehicle.*/
            VehicleDelegate vehicleDelegate01 = vehicle.createVehicle;
            vehicleDelegate01();
            /* VehicleDelegate is expecting a method with return type Vehicle(i.e.a basetype) but you're assigning 
               a method with return type Bus(a derived type) Covariance allows this kind of assignment.*/
            VehicleDelegate vehicleDelegate02 = bus.createBus;
            vehicleDelegate02();

            Console.ReadLine();
        }
    }
}
