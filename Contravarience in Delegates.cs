using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contravarience_in_Delegates
{
    class Vehicle
    {
        public void ShowVehicle(Vehicle MyVehicle)
        {
            Console.WriteLine("Inside Vehicle.ShowVehicle :- ");
            Console.WriteLine("MyVehicle.GetHashCode = {0}", MyVehicle.GetHashCode());
        }
    }
    class Bus : Vehicle
    {
        public void ShowBus (Bus  MyBus )
        {
            Console.WriteLine("Inside Bus.ShowBus  :- ");
            Console.WriteLine("MyBus.GetHashCode = {0}", MyBus.GetHashCode());
        }
    }

    class Program
    {
        public delegate void BusDelegate(Bus MyBus);
        static void Main(string[] args)
        {
            Vehicle MyVehicle = new Vehicle();
            Bus MyBus = new Bus();
            // Normal Case:
            BusDelegate dlgt1 = MyBus.ShowBus;
            dlgt1(MyBus);         // MyBus.GetHashCode = 46104728

            // Special Case Contravariance:

            /* Note that the following delegate expected a method that accepts a Bus(derived) object parameter
               but still it can point to the method that accepts Vehicle(base) object parameter */
            BusDelegate dlgt2 = MyVehicle.ShowVehicle;
            dlgt2(MyBus);         // MyVehicle.GetHashCode = 46104728

            // Additional note:you cannot pass vehicle object here
            // anotherBusDelegate(myVehicle);//error

            Console.ReadLine();
        }
    }
}
