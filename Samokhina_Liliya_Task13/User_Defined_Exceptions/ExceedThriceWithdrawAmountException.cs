using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exceptions
{
    public class ExceedThriceWithdrawAmountException : Exception
    {
        public override string Message
        {
            get
            {
                return "You can not withdraw amount more than thrice";
            }
        }
    }
}
