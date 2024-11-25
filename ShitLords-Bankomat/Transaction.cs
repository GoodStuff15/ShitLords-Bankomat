﻿namespace Shitlords_Bankomat
{
    internal class Transaction
    {
        private decimal _amount;
        private int _fromAccount;
        private int _toAccount;
        private DateTime _transferDate;

        public decimal Amount { get; set; }
        public Account FromAccount { get; set; }
        public Account ToAccount { get; set; }
        public DateTime TransferDate { get; set; }

        public Transaction(decimal amount, Account fromAccount, Account toAccount)
        {
            Amount = amount;
            FromAccount = fromAccount;
            ToAccount = toAccount;
            TransferDate = DateTime.Now;
        }
        public bool TransferFunds() //Method for moneytransfer
        {
            if(FromAccount.Amount >= Amount)
            {
                FromAccount.Amount -= Amount;
                ToAccount.Amount += Amount;
                return true;
                //LOG
            }
            else
            {
                Console.WriteLine("Transfer not complete. Check account balance");
                return false;
            }
        }
        public void Log()
        {
            var logEntry = new History
            {
                Date = TransferDate,
                Amount = Amount,
            };
            FromAccount.history.Add(logEntry);
            ToAccount.history.Add(logEntry);
        }
        public override string ToString()
        {
            return $"{TransferDate}: Amount:{Amount} | From account:{FromAccount.AccountNumber} | To account:{ToAccount.AccountNumber}";
        }
    }
}