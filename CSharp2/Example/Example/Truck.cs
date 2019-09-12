using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Truck : Vehicle
    {
        public int Kilometer { get; set; }
        public Truck(string typedanger, int cost, bool safe, int kilometer)
            : base(typedanger, cost, safe)
        {
            kilometer = Kilometer;
        }
        public override void Calculate()
        {
            base.Calculate();
            Truck camion = new Truck("Alto",50,50,7);
        }
    }
}
