# ToolWatchChallenge

This repository contains code for a simple logging library.  There are three projects in the repository:
1) TWLogger - this project contains the main logging interface as well as a concrete implimentation of the interface to log error messages to the file system.
2) TWLoggerTests - this is the project containing unit tests for the logger. ** NOT FINISHED **
3) ConsoleLoggingApp - this is a console app project for testing the logging library code.

Example usage:

 myLogger = new FileLogger();
 myLogger.Info("error message here");
 
 
