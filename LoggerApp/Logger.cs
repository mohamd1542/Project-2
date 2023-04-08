using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
           Console.WriteLine(message);
        }

        public void Log(string message, Exception messageType)
        {
            Log($"{messageType}: {message}");
        }
    }
}
