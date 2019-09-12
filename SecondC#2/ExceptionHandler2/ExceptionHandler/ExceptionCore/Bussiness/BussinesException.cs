using System;

namespace ExceptionCore.Bussiness
{
    public class BussinesException : AbstractException
    {
        public BussinesException(string friendlyMessage)
            : base(friendlyMessage, Severity.Warning)
        { }

        public override void LogException()
        {
            Console.WriteLine(FriendlyMessage);
        }
    }
}
