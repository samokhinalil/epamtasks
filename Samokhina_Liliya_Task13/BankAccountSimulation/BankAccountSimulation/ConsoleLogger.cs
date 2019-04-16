using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountSimulation
{
    class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
