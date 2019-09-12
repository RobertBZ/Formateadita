using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Vehicle
    {
        public string TypeDanger { get; set; }
        public int Cost { get; set; }
        public bool Safe { get; set; } 
        public int MoutSafe { get; set; }
        public Vehicle(string typedanger, int cost, bool safe)
        {
            typedanger = TypeDanger;
            cost = Cost;
            safe = Safe;
        }
        public virtual void Calculate()
        {
            
        }


    }
}
