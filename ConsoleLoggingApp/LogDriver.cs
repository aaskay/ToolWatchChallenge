using System;
using System.Collections.Generic;
using System.Text;

namespace TWLogger
{
    public class LogDriver
    {
        ILogger logger;

        public LogDriver(ILogger logger)
        {
            this.logger = logger;
        }
    }
}
