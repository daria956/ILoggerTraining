using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerTraining
{
    public  class EmailLogger : ILogger
    {
        private readonly string _email;
       

        public EmailLogger(string email)
        {
            _email = email;
        }
        public void LogError(string message)
        {
            Console.WriteLine($"Error {message} sent to {_email}");
        }
        public void LogInfo(string logInfo)
        {
            Console.WriteLine($" Info: {logInfo} sent to {_email}");
        }

    }
}
