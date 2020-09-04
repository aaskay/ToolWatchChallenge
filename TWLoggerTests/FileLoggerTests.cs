using Microsoft.VisualStudio.TestTools.UnitTesting;
using TWLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;

namespace TWLogger.Tests
{
    [TestClass()]
    public class FileLoggerTests
    {
        IFileSystem fileSystem = new MockFileSystem(new Dictionary<string, MockFileData>
        {
            { @"c:\ErrorLogs\Errorlog.txt", new MockFileData("Testing is meh.") },
        });

        [TestMethod()]
        public void DebugTest()
        {
            var loggerTest = new FileLogger();

            Assert.Fail();
        }

        [TestMethod()]
        public void ErrorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FatalTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InfoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void WarningTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ShouldCreateFileIfDoesNotExist()
        {
            Assert.Fail();
        }
    }
}