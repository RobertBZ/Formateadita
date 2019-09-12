using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Motocyrcle : Vehicle
    {
        public Motocyrcle(string typedanger, int cost, bool safe)
            : base(typedanger, cost, safe)
        { }
    }
}
