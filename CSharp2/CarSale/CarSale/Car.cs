using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale
{
    public class Car :Vehicle
    {
        public int KmExtra;
        public Car(int hoursused, int danger, bool insurance, int kmextra)
            : base(hoursused, danger, insurance)
        {
            KmExtra = kmextra;
        }

        public override void RentsVehicle(int costhours, int hkextra, double costextra, int costinsurance, string tipo)
        {
            int costhoursa = 10;
            int hkextraa = KmExtra;
            double costextraa = 2.5;
            int costinsurancea = 25;
            string tipoa = "auto";
            base.RentsVehicle(costhoursa, hkextraa, costextraa, costinsurancea, tipoa);
        }
    }
}
