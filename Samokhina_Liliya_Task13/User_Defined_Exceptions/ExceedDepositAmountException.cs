using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exceptions
{
    public class ExceedDepositAmountException : Exception
    {
        private string maxDepositAmount;

        public override string Message
        {
            get
            {
                return "You can not deposit amount greater than" + maxDepositAmount;
            }
        }

        public ExceedDepositAmountException(string maxDepositAmount)
        {
            this.maxDepositAmount = maxDepositAmount;
        }
    }
}
