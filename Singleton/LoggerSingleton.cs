using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class LoggerSingleton
    {
        private LoggerSingleton()
        { }

        private int logCount = 0;
        private static volatile LoggerSingleton loggerSingletonInstance = null;
        private static readonly object locker = new object();

        public static LoggerSingleton GetInstance()
        {
            lock (locker)
            {
                if (loggerSingletonInstance == null)
                {
                    lock (locker)
                    {
                        loggerSingletonInstance = new LoggerSingleton();
                    }
                }
            }

            return loggerSingletonInstance;
        }

        public void Log(string message)
        {
            Console.WriteLine(logCount + ": " + message);
            logCount++;
        }
    }
}
