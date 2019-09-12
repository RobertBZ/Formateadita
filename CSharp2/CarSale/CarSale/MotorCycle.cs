using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale
{
    public class MotorCycle :Vehicle
    {
        public int HoursExtra;
        public MotorCycle(int hoursused, int danger, bool insurance, int hoursextra)
            : base(hoursused, danger, insurance)
        {
            HoursExtra = hoursextra;
        }

        public override void RentsVehicle(int costhours, int hkextra, double costextra, int costinsurance, string tipo)
        {
            int costhoursa = 15;
            int hkextraa = HoursExtra;
            double costextraa = 5;
            int costinsurancea = 50;
            string tipoa = "moto";
            base.RentsVehicle(costhoursa, hkextraa, costextraa, costinsurancea, tipoa);
        }
    }
}
