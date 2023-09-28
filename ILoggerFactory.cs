using ILoggerTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerTraining
{
    public interface ILoggerFactory
    {
        ILogger Create();
    }
}
