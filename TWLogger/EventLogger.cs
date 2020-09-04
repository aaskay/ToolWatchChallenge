using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWLogger
{
    public class EventLogger
    {
        public void LogToEventViewer(string message, LogLevel level, int source)
        {
            EventLogEntryType eventLogEntryType;
            switch (level)
            {
                case LogLevel.Debug:
                case LogLevel.Info:
                    eventLogEntryType = EventLogEntryType.Information;
                    break;                
                case LogLevel.Warning:
                    eventLogEntryType = EventLogEntryType.Warning;
                    break;
                case LogLevel.Error:
                case LogLevel.Fatal:
                    eventLogEntryType = EventLogEntryType.Error;
                    break;
                default:
                    eventLogEntryType = EventLogEntryType.Information;
                    break;
            }

            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry(message, eventLogEntryType, source);
            }
        }        
    }
}
