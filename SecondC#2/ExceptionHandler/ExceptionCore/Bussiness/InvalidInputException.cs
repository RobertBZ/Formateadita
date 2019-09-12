using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCore.Bussiness
{
    public class InvalidInputException : BussinessException
    {
        public InvalidInputException(int end)
            : base(string.Format(
                "Dato introducido no es valido, por favor ingresa un numero entre 1 y {0}", end))
        { }
    }
}
