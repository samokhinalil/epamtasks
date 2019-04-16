using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exceptions
{
    public class GenerateReportException : Exception
    {
        public override string Message
        {
            get
            {
                return "Insifficient amount of funds to generate report";
            }
        }
    }
}
