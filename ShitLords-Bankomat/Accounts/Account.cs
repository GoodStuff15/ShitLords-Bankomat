using System;

namespace Shitlords_Bankomat
{
    public abstract class Account
    {
       // public List<History> history;
        private string _accountName;
        private decimal _amount;
        private decimal _currency;
        private int _accountNumber;
        private string _ownerID;

        public abstract string AccountType { get; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public int AccountNumber { get; set; }
        public string OwnerID { get; set; }
        public decimal Interest { get; set; }


        public Account(decimal balance, string currency, int accountNumber, string ownerID)
        {
           //history = new List<History>();
            Balance = balance;
            Currency = currency;
            AccountNumber = accountNumber;
            OwnerID = ownerID;
        }

        public abstract decimal GetInterest();

        public override string ToString()
        {
            return $"{OwnerID}|{AccountNumber}|{Balance}|{Currency}";
        }
    }
}
