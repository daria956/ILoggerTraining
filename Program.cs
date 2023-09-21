using Newtonsoft.Json;

namespace ILoggerTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ILogger consoleLogger = new EmailLogger("daria.sokulska@gmail.com");
            consoleLogger.LogError("Test");

            ConsoleLogger consoleLogger2 = new ConsoleLogger();
            var logginService = new LogginService(consoleLogger2);

            logginService.LogInfo();

            var logginServiceFile = new LogginService(new FileLogger("C:\\serviceLog.txt"));
            logginServiceFile.LogError();

            var logginServiceEmail = new LogginService(new EmailLogger("daria.pietka@gmail.com"));
            logginServiceEmail.LogInfo();

            //deserializacja JSON
            var path = @"C:\Users\DSOKULSKA\User.txt";
            var json = File.ReadAllText(path);
            Person user1 = JsonConvert.DeserializeObject<Person>(json)!;
            Console.WriteLine(user1.ToString());

            //serializacja
            Person userAnna = new Person("Anna", "Rogulska", 25 );
            var json2 = @"C:\Users\DSOKULSKA\User2.txt";
            var userToString = JsonConvert.SerializeObject(userAnna);
            File.WriteAllText(json2, userToString);
            
        }
    }
    

}