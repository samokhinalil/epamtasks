using System;

namespace BankAccountSimulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();

            try
            {
                BankAccount savingAccount = new SavingBankAccount("Sarvesh", "S12345", logger);
                BankAccount currentAccount = new CurrentBankAccount("Mark", "C12345", logger);

                savingAccount.Deposit(400000);
                savingAccount.Withdraw(100000000);
                //savingAccount.Withdraw(1000);
                //savingAccount.Withdraw(1000);

                // Generate Report
                savingAccount.GenerateAccountReport();
                
                currentAccount.Deposit(190000);
                currentAccount.Withdraw(1000);
                currentAccount.GenerateAccountReport();
            }
            catch (ArgumentNullException e)
            {
                logger.Write(e.Message);
            }
            catch (User_Defined_Exceptions.MinimumBalanceLimitException e)
            {
                logger.Write(e.Message);
            }
            catch (User_Defined_Exceptions.ExceedDepositAmountException e)
            {
                logger.Write(e.Message);
            }
            catch (User_Defined_Exceptions.ExceedThriceWithdrawAmountException e)
            {
                logger.Write(e.Message);
            }
            catch (User_Defined_Exceptions.GenerateReportException e)
            {
                logger.Write(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
