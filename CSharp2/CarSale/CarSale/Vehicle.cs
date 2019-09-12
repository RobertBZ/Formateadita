using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale
{
    public abstract class Vehicle
    {
        public int HoursUsed;

        public int Danger;

        public bool Insurance;

        public Vehicle(int hoursused, int danger, bool insurance)
        {
            HoursUsed = hoursused;
            Danger = danger;
            Insurance = insurance;
        }

        public virtual void RentsVehicle(int costhours,int hkextra,double costextra,int costinsurance, string tipo)
        {
            double Total;
            if (Insurance == false)
            {
                Total = ((Double)HoursUsed * costhours) + ((Double)hkextra * costextra);
            }
            else
            {
                Total = ((Double)HoursUsed * costhours) + ((Double)hkextra * costextra) + costinsurance;
            }
            Console.WriteLine("El total a pagar por el {0} es: {1}", tipo,Total);
        }
    }
}
