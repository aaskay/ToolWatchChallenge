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
            mylogger.TryToLogInfo("This is an info message");
            mylogger.TryToLogInfo("This is another info message");
            mylogger.TryToLogError("This is an error message");
        }
    }
}
