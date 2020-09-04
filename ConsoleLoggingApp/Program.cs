using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWLogger;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLogger mylogger = new MyLogger(new FileLogger());
            mylogger.TryToLogInfo("info");
            mylogger.TryToLogError("error");
            mylogger.TryToLogDebug("debug");
            mylogger.TryToLogFatal("fatal");
            mylogger.TryToLogWarning("warning");
        }
    }
}
