using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci
{
    public class FibonnacciRegression : AbstractRegression
    {
        public FibonnacciRegression()
        {
            BeforePrevious = 1;
            Previous = 1;
            Current = 1;
        }

        public override int Calculate()
        {
            return Previous + BeforePrevious;
        }
    }
}
