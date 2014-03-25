using NLog;

namespace System
{
    public class Logger
    {
        private static readonly NLog.Logger LoggerInstance = LogManager.GetCurrentClassLogger();

        public static void Debug(string message, params object[] args)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Debug, LoggerInstance.Name, null, message, args);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

        public static void Error(string message, params object[] args)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Error, LoggerInstance.Name, null, message, args);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

        public static void ErrorException(string message, System.Exception exception)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Error, LoggerInstance.Name, null, message, null, exception);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

        public static void ErrorException(System.Exception exception,string message, params object[] args)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Error, LoggerInstance.Name, null, message, args, exception);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

        public static void ErrorException(System.Exception exception)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Error, LoggerInstance.Name, null, null, null, exception);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

        public static void Info(string message, params object[] args)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Info, LoggerInstance.Name, null, message, args);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

        public static void Trace(string message, params object[] args)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Trace, LoggerInstance.Name, null, message, args);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

        public static void Warn(string message, params object[] args)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Warn, LoggerInstance.Name, null, message, args);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

        public static void FatalException(string message, System.Exception exception)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Fatal, LoggerInstance.Name, null, message, null, exception);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

        public static void FatalException(System.Exception exception, string message, params object[] args)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Fatal, LoggerInstance.Name, null, message, args, exception);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

        public static void FatalException(System.Exception exception)
        {
            var logEventInfo = new LogEventInfo(LogLevel.Fatal, LoggerInstance.Name, null, null, null, exception);
            LoggerInstance.Log(typeof(Logger), logEventInfo);
        }

    }
}
