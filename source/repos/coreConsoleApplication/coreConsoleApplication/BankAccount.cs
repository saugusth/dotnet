﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    public abstract class BankAccount
    {

    }

    public class SavingAccount : BankAccount
    {
        public void balance()
        {
            Console.WriteLine("Balance in Saving Account");
        }

        public void deposit()
        {
            Console.WriteLine("Deposit in Saving Account");
        }

        public void withdraw()
        {
            Console.WriteLine("Withdraw from saving Account");
        }
    }


}
