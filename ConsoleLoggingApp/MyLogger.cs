using System;
using System.Collections.Generic;
using System.Text;

namespace TWLogger
{
    public class MyLogger
    {
        ILogger logger;

        public MyLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void TryToLogInfo(string message)
        {
            logger.Info(message);
        }

        public void TryToLogDebug(string message)
        {
            logger.Debug(message);
        }

        public void TryToLogWarning(string message)
        {
            logger.Warning(message);
        }

        public void TryToLogError(string message)
        {
            logger.Error(message);
        }

        public void TryToLogFatal(string message)
        {
            logger.Fatal(message);
        }
    }
}
