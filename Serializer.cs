using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerTraining
{
    public class Serializer : ISerializer
    {
        public T Deserialize<T>(string path)
        {
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(json)!;
        }

        public void Serialize<T>(T obj, string path) 
        {
            var userToString = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(path, userToString); 
        }
    }
}
