using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BankApp
{
    static class Bank
    {
        ///<summary> This is the UI, or rather what the customer sees. Keep this clean and simple.
        ///In C# the parameters are not optional unless you have a default value (look at 
        ///TypeOfAccounts) anything that follows the optional as well (initalDeposit)
        ///</summary> 
        public Account CreateAccount(string 
            string accountName,
            string emailAddress,
            TypeOfAccounts accountType = TypeOfAccounts.Checking,
            decimal intialDeposit = 0)
        {
            /// <summary>object initalization
            /// var account = new Account();
            /// Account.AccountName = accountName;
            /// more efficient way...
            ///</summary>
            var account = new Account
            {
                AccountName = accountName,
                EmailAddress = emailAddress,
                AccountType = accountType,

            };

            if (initialDeposit > 0)
            {
                account.Deposit(initialDeposit);
            }

            return account;
            ///<summary> encapuslation - everything hidden or the details are not seen
            ///</summary>
        }
    }
}
