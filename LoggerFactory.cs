using ILoggerTraining.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ILoggerTraining
{
    public class LoggerFactory : ILoggerFactory
    {
        private readonly ISerializer _serializer;
        public LoggerFactory(ISerializer serializer)
        {
                _serializer = serializer;
        }
        public ILogger Create()
        {
            ILogger logger = null;

            var settings = _serializer.Deserialize<Settings>(@"C:\Users\DSOKULSKA\AppSettings.txt");
            //var settings = new Settings();
           //settings.LoggerType = ConfigurationManager.AppSettings["loggerType"]!;
            
            switch (settings.LoggerType.ToLower())
            {
                case "file":
                    Console.WriteLine("File");
                    return logger = new FileLogger(@"C:\Users\DSOKULSKA\LoggerMessage.txt");
                case "console":
                    Console.WriteLine("Console");
                    return logger = new ConsoleLogger();
                case "email":
                    Console.WriteLine("Email");
                    return logger = new EmailLogger("daria.pietka@gmail.com");
                default:
                    Console.WriteLine("LoggerType not exist: " + settings);
                    throw new Exception("LoggerType not exist: " + settings);
            }
        }
    }
}
