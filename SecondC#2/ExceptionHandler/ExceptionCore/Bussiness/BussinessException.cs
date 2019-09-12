using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCore.Bussiness
{
    public class BussinessException : AbstractException
    {
        public BussinessException(string friendlyMessage)
            : base(friendlyMessage, Severity.Warning)
        { }

        public override void LogException()
        {
            Logger.Intance.Write(Severity, FriendlyMessage);
            Logger.Intance.Write(Severity, StackTrace);
        }
    }
}
