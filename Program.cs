namespace ILoggerTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new ConsoleLogger();
            consoleLogger.LogError("Test1");

            //    var logginService = new LoggininService(new ConsoleLogger());
            //    logginService.LogInfo();

            // var logginServiceFile = new LoggininService(new FileLogger("C:\\serviceLog.txt"));
            //logginServiceFile.LogError();

            //    var logginServiceEmail = new LoggininService(new EmailLogger("daria.pietka@gmail.com"));
            //    logginServiceEmail.LogInfo();     var consoleLogger= new ConsoleLogger();
            
        }
    }
}