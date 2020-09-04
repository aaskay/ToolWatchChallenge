using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWLogger;
using System.Configuration;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            string logPath = ConfigurationManager.AppSettings["LogDirectory"];
            bool logToEventViewer = Convert.ToBoolean(ConfigurationManager.AppSettings["LogToEventViewer"]);

            MyLogger mylogger = new MyLogger(new FileLogger(logPath, logToEventViewer));

            mylogger.TryToLogInfo("info");
            mylogger.TryToLogError("error");
            mylogger.TryToLogDebug("debug");
            mylogger.TryToLogFatal("fatal");
            mylogger.TryToLogWarning("warning");
        }
    }
}
