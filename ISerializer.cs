using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerTraining
{
    public interface ISerializer
    {
        void Serialize<T>(T obj, string path);
        T Deserialize<T>(string path);
    }
}
