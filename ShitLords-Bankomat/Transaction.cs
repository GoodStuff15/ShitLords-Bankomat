namespace Shitlords_Bankomat
{
    public class Transaction
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
            if(FromAccount.Balance >= Amount)
            {
                Transaction transaction = new Transaction(Amount, FromAccount, ToAccount);
                FromAccount.Balance -= Amount;
                ToAccount.Balance += Amount;
                var transactionDataHandler = new TransactionDataHandler();
                transactionDataHandler.Save(transaction);
                return true;
            }
            else
            {
                Console.WriteLine("Transfer not complete. Check account balance");
                return false;
            }
        }
       
        public override string ToString()
        {
            return $"{TransferDate}|{Amount}|{FromAccount.AccountNumber}|{ToAccount.AccountNumber}";
        }
    }
}
