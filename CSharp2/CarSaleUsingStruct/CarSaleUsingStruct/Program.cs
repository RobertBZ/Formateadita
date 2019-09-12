using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaleUsingStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstcar = new Car(5, 1, false, 35);
            Truck firsttruck = new Truck(10, 3, true, 50);
            Motorcycle firstmotorcycle = new Motorcycle(7, 2, true, 14);

            firstcar.RentsVehicle();
            Console.WriteLine("================================");
            firsttruck.RentsVehicle();
            Console.WriteLine("================================");
            firstmotorcycle.RentsVehicle();
            Console.ReadKey();
        }
    }
}
