using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerTraining
{
    public interface ILogger
    {
        void LogError(string logError);
        void LogInfo(string logInfo);
    }
}
