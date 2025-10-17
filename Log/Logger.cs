using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Log
{
    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }

    public class AdvancedLoggerSync
    {
        private readonly string _logDirectory;
        private readonly object _lock = new object();

        public AdvancedLoggerSync(string logDirectory)
        {
            _logDirectory = logDirectory;

            if (!Directory.Exists(_logDirectory))
                Directory.CreateDirectory(_logDirectory);
        }

        public void Log(string message, LogLevel level = LogLevel.Info)
        {
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";
            string filePath = GetLogFilePath();

            lock (_lock)
            {
                File.AppendAllText(filePath, logEntry + Environment.NewLine);
            }
        }

        private string GetLogFilePath()
        {
            string fileName = $"log_{DateTime.Now:yyyyMMdd}.txt";
            return Path.Combine(_logDirectory, fileName);
        }
    }

}
