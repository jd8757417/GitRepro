using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    enum TypeOfAccounts
    {
        Checking,
        Savings,
        CD,
        Loan
    }
    /// <summary>
    /// This represents a bank account 
    /// where you can withdraw or deposit
    /// money into the account
    /// </summary>
    class Account
    {
        #region Properties
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public TypeOfAccounts AccountType { get; set; }
        public decimal Balance { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion
        //single line comment
        /* multiple line comment
         * */
    }
}
