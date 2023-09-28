using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerTraining
{
    public class LogginService
    {
        private readonly ILogger _logger;
        public LogginService(ILogger logger)
        {
            _logger = logger;
        }
        public void LogInfo()
        {
            _logger.LogInfo($"Nowe info o godzinie : {DateTime.Now}");
        }
        public void LogError()
        {
            _logger.LogError($"Nowy bład o godzinie: {DateTime.Now}");
        }
    }
}
