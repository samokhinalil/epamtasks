using System;

namespace BankAccountSimulation
{
    public class CurrentBankAccount : BankAccount
    {
        public CurrentBankAccount(string accountOwnerName, string accountNumber, ILogger logger)
            : base(accountOwnerName, accountNumber, logger)
        {
            this.MinAccountBalance = 0m;
            this.MaxDepositAmount = 100000000m;
            InteresetRate = .25m;
        }

        public override void Deposit(decimal amount)
        {
            AccountBalance = AccountBalance + amount;
            TransactionSummary = string.Format("{0}\n Deposit:{1}", TransactionSummary, amount);
        }

        public override void Withdraw(decimal amount)
        {
            if (AccountBalance - amount <= MinAccountBalance)
            {
                throw new User_Defined_Exceptions.MinimumBalanceLimitException("Current Account");
                //throw new Exception("You can not withdraw amount from your Current Account as Minimum Balance limit is reached");
            }

            AccountBalance = AccountBalance - amount;
            TransactionSummary = string.Format("{0}\n Withdraw:{1}", TransactionSummary, amount);
        }

        public override void GenerateAccountReport()
        {
            logger.Write("Current Account Report");
            base.GenerateAccountReport();
        }
    }
}
