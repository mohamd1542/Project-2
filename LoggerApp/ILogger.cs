using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp
{
    public interface ILogger
    {
        void Log(string message);
        void Log(string message, Exception messageType);
    }
}
