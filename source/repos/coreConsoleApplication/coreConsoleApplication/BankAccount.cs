using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    public abstract class BankAccount
    {
        public abstract void deposit();
        public abstract void withdraw();
        public abstract void balance();
    }

    public class SavingAccount : BankAccount
    {
        public override void balance()
        {
            Console.WriteLine("Balance in Saving Account");
        }

        public override void deposit()
        {
            Console.WriteLine("Deposit in Saving Account");
        }

        public override void withdraw()
        {
            Console.WriteLine("Withdraw from saving Account");
        }
    }
}
