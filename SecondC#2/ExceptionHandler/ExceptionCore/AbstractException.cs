using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCore
{
    public abstract class AbstractException : Exception
    {
        public string FriendlyMessage { get; protected set; }
        protected Severity Severity { get; set; }
        public new Exception InnerException { get; set; }
        protected AbstractException(string frinedlyMessage, Severity severity)
        {
            this.FriendlyMessage = frinedlyMessage;
            this.Severity = severity;
        }
        protected AbstractException(string frinedlyMessage, Severity severity, Exception exception)
            : this(frinedlyMessage, severity)
        {
            this.InnerException = exception;
        }
        public abstract void LogException();
    }
}
