using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerTraining
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string logError)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"Błąd: {logError}");
            }
        }
        public void LogInfo(string logInfo)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"Informacja {logInfo}");
                streamWriter.WriteLine("Informacja" + logInfo);
                streamWriter.WriteLine("Informacja {0}", logInfo);
            }
        }
    }
}
