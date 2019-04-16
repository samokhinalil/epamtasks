using System;

namespace BankAccountSimulation
{
    public abstract class BankAccount
    {
        private string accountOwnerName;
        private string accountNumber;

        protected ILogger logger;

        // thi variable will hold the summary of all the transaction that took place
        protected string TransactionSummary { get; set; }

        // Name of the Account Owner, Its common for all derived classes
        public string AccountOwnerName
        {
            get
            {
                return accountOwnerName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    accountOwnerName = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        // Account Number field is a common field for all the account types
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    accountNumber = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        // A field to hold the Account Balance
        public decimal AccountBalance { get; protected set; }

        // A field to hold the MinimumAccount Balance
        protected decimal MinAccountBalance { get; set; }

        // A field to hold the Max Deposit Amount Balance
        protected decimal MaxDepositAmount { get; set; }

        protected decimal InteresetRate { get; set; }

        public BankAccount(string accountOwnerName, string accountNumber, ILogger logger)
        {
            this.logger = logger;
            AccountOwnerName = accountOwnerName;
            AccountNumber = accountNumber;
            TransactionSummary = string.Empty;
        }

        // Depsoit is an abstract method so that Saving/Current Account must override it to give 
        // their specific implementaion.
        public abstract void Deposit(decimal amount);

        // Withdraw is an abstract method so that Saving/Current Account must override it to give 
        // their specific implementaion.
        public abstract void Withdraw(decimal amount);


        public decimal CalculateInterest()
        {
            return (this.AccountBalance * this.InteresetRate) / 100;
        }

        // This methodadds a Reporting functionality to the Bank Account
        public virtual void GenerateAccountReport()
        {
            logger.Write($"Account Owner:{this.AccountOwnerName}, Account Number:{this.AccountNumber}," +
                $" AccountBalance:{this.AccountBalance}");
            logger.Write($"Interest Amount:{CalculateInterest()}");
            logger.Write(this.TransactionSummary);
        }
    }
}
