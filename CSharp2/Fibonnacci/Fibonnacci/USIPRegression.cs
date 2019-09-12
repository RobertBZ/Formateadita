using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci
{
    public class USIPRegression : AbstractRegression
    {
        public USIPRegression()
        {
            BeforePrevious = 0;
            Previous = 1;
        }
        public override int Calculate()
        {
            return (Previous * BeforePrevious) + Previous;
        }
    }
}
