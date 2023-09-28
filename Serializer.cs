using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerTraining
{
    public static class Serializer
    {
        public static void Serialize<T>(T obj, string path) where T : class
        {
            var userToString = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(path, userToString);
        }

        public static T Deserialize<T>(string path) where T : class
        {
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(json)!;
        }
    }
}
