using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale
{
    public class Truck :Vehicle
    {
        public int KmExtra;
        public Truck(int hoursused, int danger, bool insurance, int kmextra)
            : base(hoursused, danger, insurance)
        {
            KmExtra = kmextra;
        }

        public override void RentsVehicle(int costhours, int hkextra, double costextra, int costinsurance, string tipo)
        {
            int costhoursa = 50;
            int hkextraa = KmExtra;
            double costextraa = 7;
            int costinsurancea = 50;
            string tipoa = "camion";
            base.RentsVehicle(costhoursa, hkextraa, costextraa, costinsurancea, tipoa);
        }
    }
}
