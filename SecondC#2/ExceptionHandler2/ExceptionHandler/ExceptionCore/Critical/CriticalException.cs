using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCore.Critical
{
    public class CriticalException : AbstractException
    {
        public CriticalException(Exception exception)
            : base("Ha ocurrido un error. Contacte con el administrador",
                  Severity.Error, 
                  exception)
        { }

        public override void LogException()
        {
            var current = InnerException;
            do
            {
                Console.WriteLine(current.Message);
                Console.WriteLine(current.StackTrace);
                current = current.InnerException;
            } while (current != null);
        }
    }
}
