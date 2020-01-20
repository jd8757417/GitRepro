using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary> var myAccount = new Account();
            ///  myAccount.AccountName = 123456;
            ///  myAccount.AccountName = "My Checking";
            ///  myAccount.AccountType = TypeOfAccounts.Checking
            ///  var myAccount2 = new Account();
            /// Better way...  </summary>
            /// Now created an account in the bank
            var myAccount = Bank.CreateAccount("My checking", test@test.com, intialDeposit: 100);
            Console.WriteLine 
        }
    }
}
