using System;

namespace ExceptionCore.Critical
{
    public class CriticalException : AbstractException
    {
        public CriticalException(Exception exception)
            : base("Ha orcurrido un error. Contacte con el administrador", Severity.Error, exception)
        { }
        public override void LogException()
        {
            var current = InnerException;
            do
            {
                Logger.Intance.Write(Severity, current.Message);
                Logger.Intance.Write(Severity, current.StackTrace);
                current = current.InnerException;
            } while (current != null);
        }
    }
}
