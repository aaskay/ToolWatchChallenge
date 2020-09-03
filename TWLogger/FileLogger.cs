using System;
using System.IO;

namespace TWLogger
{
    public class FileLogger : ILogger
    {        
        private void Log(LogLevel level,string message)
        {
            string path;

            string baseLogFilePath = @"C:\Errorlogs";

            if (!(Directory.Exists(baseLogFilePath)))
            {
                Directory.CreateDirectory(baseLogFilePath);
            }

            switch (level)
            {
                case LogLevel.Info:
                    path = baseLogFilePath + @"\ErrorLog.info";
                    break;
                case LogLevel.Debug:
                    path = baseLogFilePath + @"\ErrorLog.debug";
                    break;
                case LogLevel.Warning:
                    path = baseLogFilePath + @"\ErrorLog.warning";
                    break;
                case LogLevel.Error:
                    path = baseLogFilePath + @"\ErrorLog.error";
                    break;
                case LogLevel.Fatal:
                    path = baseLogFilePath + @"\ErrorLog.fatal";
                    break;
                default:
                    path = baseLogFilePath + @"\ErrorLog.txt";
                    break;
            }
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }

        public void Debug(string message)
        {
            Log(LogLevel.Debug, message);
        }

        public void Error(string message)
        {
            Log(LogLevel.Error, message);
        }

        public void Fatal(string message)
        {
            Log(LogLevel.Fatal, message);
        }
        public void Info(string message)
        {
            Log(LogLevel.Info, message);
        }
        public void Warning(string message)
        {
            Log(LogLevel.Warning, message);
        }
    }

    public enum LogLevel
    {
        Info,
        Debug,
        Warning,
        Error,
        Fatal
    }
}
