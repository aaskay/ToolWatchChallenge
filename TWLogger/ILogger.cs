﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TWLogger
{
    public interface ILogger
    {
        void Info(string message);
        void Debug(string message);
        void Warning(string message);
        void Error(string message);
        void Fatal(string message);
    }
}
