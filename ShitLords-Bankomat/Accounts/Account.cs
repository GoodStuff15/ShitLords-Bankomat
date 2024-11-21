using System;

namespace Shitlords_Bankomat
{
    public abstract class Account
    {
        public List<History> history;
        private string _accountName;
        private decimal _amount;
        private decimal _currency;
        private int _accountNumber;
        private int _ownerID;

        public abstract string AccountType { get; set; }
        public decimal Amount { get; set; }
        public decimal Currency { get; set; }
        public int AccountNumber { get; set; }
        public int OwnerID { get; set; }


        public Account(string accountType, decimal amount, decimal currency, int accountNumber, int ownerID)
        {
            history = new List<History>();
            AccountType = accountType;
            Amount = amount;
            Currency = currency;
            AccountNumber = accountNumber;
            OwnerID = ownerID;
        }

        public override string ToString()
        {
            return $"{OwnerID}|{AccountNumber}|{Amount}|{Currency}";
        }


    }
}
//Har också ett önskemål: Att i User- och Account-klasserna göra en metod som returnerar en string med all viktig info på en rad, separerade med ett |.  
 
//typ return $"{userid}|{userType}|{firstName}|{lastName}"  
