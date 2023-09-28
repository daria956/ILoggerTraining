using ILoggerTraining.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Configuration;

namespace ILoggerTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ILogger consoleLogger = new EmailLogger("daria.sokulska@gmail.com");
            //consoleLogger.LogError("Test");

            //ConsoleLogger consoleLogger2 = new ConsoleLogger();
            //var logginService = new LogginService(consoleLogger2);

            //logginService.LogInfo();

            //var logginServiceFile = new LogginService(new FileLogger("C:\\serviceLog.txt"));
            //logginServiceFile.LogError();

            //var logginServiceEmail = new LogginService(new EmailLogger("daria.pietka@gmail.com"));
            //logginServiceEmail.LogInfo();

            //Deserialize<Person>(@"C:\Users\DSOKULSKA\User.txt");

            //deserializacja JSON
            //var path = @"C:\Users\DSOKULSKA\User.txt";
            //var json = File.ReadAllText(path);
            //Person user1 = JsonConvert.DeserializeObject<Person>(json)!;
            //Console.WriteLine(user1.ToString());

            ////serializacja
            //Person userAnna = new Person("Anna", "Rogulska", 25 );
            //var json2 = @"C:\Users\DSOKULSKA\User2.txt";
            //var userToString = JsonConvert.SerializeObject(userAnna, Formatting.Indented);
            //File.WriteAllText(json2, userToString);
            //Console.WriteLine(userAnna.ToString());

            //var path1 = @"C:\Users\DSOKULSKA\AppSettings.txt";
            //var json3 = File.ReadAllText(path1);
            //Settings setting = JsonConvert.DeserializeObject<Settings>(json3)!;
            //Console.WriteLine(setting.LoggerType);

            //switch (setting.LoggerType.ToLower())
            //{   
            //    case "file" :
            //        Console.WriteLine("File");
            //        logger = new FileLogger(@"C:\Users\DSOKULSKA\LoggerMessage.txt");
            //        break;
            //    case "console":
            //        Console.WriteLine("Console");
            //        logger = new ConsoleLogger();
            //        break;
            //    case "email":
            //        Console.WriteLine("Email");
            //        logger = new EmailLogger("daria.pietka@gmail.com");
            //        break;
            //    default:
            //        Console.WriteLine("LoggerType not exist: " + setting.LoggerType);
            //        throw new Exception("LoggerType not exist: " + setting.LoggerType);
            //}
            //Console.WriteLine("****************");

            //var logginService = new LogginService(logger);
            //logginService.LogInfo();
            //logginService.LogError();
            ////var paths = @"C:\Loggs\Info.txt";
            ////File.AppendAllLines(paths, logger);
            //Console.ReadLine();
            Console.WriteLine("****************");

            ILogger logger = null;
            var builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddSingleton<ILoggerFactory, LoggerFactory>();
            builder.Services.AddSingleton<ISerializer, Serializer>();
            var app = builder.Build();  
            var loggerFactory = app.Services.GetService<ILoggerFactory>();
            var provider = loggerFactory.Create();
            provider.LogInfo($"{DateTime.Now}");
            
        }

    }
    

}