using System;

namespace ExceptionCore
{
    public abstract class AbstractException : Exception
    {
        public string FriendlyMessage { get; protected set; }
        protected Severity Severity { get; set; }
        public new Exception InnerException { get; set; }

        protected AbstractException(string friendlyMessage, Severity severity)
        {
            FriendlyMessage = friendlyMessage;
            Severity = severity;
        }

        protected AbstractException(string friendlyMessage, Severity severity, Exception exception)
            : this(friendlyMessage, severity)
        {
            InnerException = exception;
        }

        public abstract void LogException();
    }
}
