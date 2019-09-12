using log4net;
using log4net.Config;

namespace ExceptionCore
{
    public class Logger
    {
        private readonly ILog logger;
        private static Logger instance;
        public static Logger Intance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        public Logger()
        {
            logger = LogManager.GetLogger("Logger");
            XmlConfigurator.Configure();
        }

        public void Write(Severity severity, string message)
        {
            switch (severity)
            {
                case Severity.Fatal:
                    logger.Fatal(message);
                    break;
                case Severity.Error:
                    logger.Error(message);
                    break;
                case Severity.Warning:
                    logger.Warn(message);
                    break;
                case Severity.Information:
                    logger.Info(message);
                    break;
                case Severity.Debug:
                    logger.Debug(message);
                    break;
            }
        }
    }
}
