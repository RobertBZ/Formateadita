using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCore.Bussiness
{
    public class AbsoluteException : BussinessException
    {
        public AbsoluteException(int res)
            : base(string.Format(
                "El numero {0} no puede ser calculable", res))
        { }
    }
}
