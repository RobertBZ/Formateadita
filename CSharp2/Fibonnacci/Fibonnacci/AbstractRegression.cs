using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci
{
    public abstract class AbstractRegression
    {
        protected int Previous { get; set; }
        protected int BeforePrevious { get; set; }
        protected int Pivot { get; set; }
        public int Current { get; protected set; }

        protected AbstractRegression()
        {            
            Pivot = 0;
        }

        public abstract int Calculate();

        public bool GetNext(int quantity)
        {
            if (Pivot == 0)
            {
                Current = BeforePrevious;
            }
            else if (Pivot == 1)
            {
                Current = Previous;
            }
            else
            {
                Current = Calculate();
                BeforePrevious = Previous;
                Previous = Current;
            }
            Pivot++;
            return (Pivot < quantity);
        }
    }
}
