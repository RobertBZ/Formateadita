using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaleUsingStruct
{
    struct Truck : Vehicle
    {
        public int KmExtra;
        public int HoursUsed;
        public int Danger;
        public bool Insurance;
        public Truck(int hoursused, int danger, bool insurance, int kmextra)
        {
            KmExtra = kmextra;
            HoursUsed = hoursused;
            Danger = danger;
            Insurance = insurance;
        }
        public void RentsVehicle()
        {
            int costhoursa = 50;
            int hkextraa = KmExtra;
            double costextraa = 7;
            int costinsurancea = 50;
            string tipoa = "camion";
            Calculate(costhoursa, hkextraa, costextraa, costinsurancea, tipoa);
        }
        public void Calculate(int costhours, int hkextra, double costextra, int costinsurance, string tipo)
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
            Console.WriteLine("El total a pagar por el {0} es: {1}", tipo, Total);
        }
    }
}
