using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale
{
    class Program
    {
        static void Report(Vehicle instance)
        {
            instance.RentsVehicle(0,0,0,0,"");
        }
        static void Main(string[] args)
        {
            Car firstcar = new Car(5, 1, false, 35);
            Truck firsttruck = new Truck(10, 3, true, 50);
            MotorCycle firstmotorcycle = new MotorCycle(7, 2, true, 14);

            Report(firstcar);
            Console.WriteLine("================================");
            Report(firsttruck);
            Console.WriteLine("================================");
            Report(firstmotorcycle);
            Console.ReadKey();
        }
    }
}
