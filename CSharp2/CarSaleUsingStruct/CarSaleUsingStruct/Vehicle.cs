using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaleUsingStruct
{
    interface Vehicle
    {
        void RentsVehicle();
        void Calculate(int costhours, int hkextra, double costextra, int costinsurance, string tipo);
    }
}
