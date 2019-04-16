using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exceptions
{
    public class MinimumBalanceLimitException : Exception
    {
        private string bankAccountType;

        public override string Message
        {
            get
            {
                return $"You can not withdraw amount from your {bankAccountType} as Minimum Balance limit is reached";
            }
        }

        public MinimumBalanceLimitException(string bankAccountType)
        {
            this.bankAccountType = bankAccountType;
        }
    }
}
