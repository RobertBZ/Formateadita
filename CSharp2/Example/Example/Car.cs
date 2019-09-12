using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Car : Vehicle
    {
        public int Kilometer { get; set; }
        public Car(string typedanger, int cost, bool safe, int kilometer)
            : base(typedanger, cost, safe)
        {
            kilometer = Kilometer;
        }
        public override void Calculate()
        {
            int mount;
            TypeDanger = "Baja";
            
        }
    }
}
