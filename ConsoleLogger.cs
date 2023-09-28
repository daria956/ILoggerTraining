using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerTraining
{
    public class ConsoleLogger : ILogger
    {
        
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
        public void LogInfo(string logInfo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(logInfo);
        }
    }
}
