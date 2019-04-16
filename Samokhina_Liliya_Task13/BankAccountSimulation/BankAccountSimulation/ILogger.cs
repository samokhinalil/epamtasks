using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountSimulation
{
    public interface ILogger
    {
        void Write(string message);
    }
}
