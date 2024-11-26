namespace Shitlords_Bankomat
{
    public abstract class TransactionFactory
    {
        public abstract Transaction DoTransaction(TransactionDataHandler transactionDataHandler);
        public Transaction CreateTransaction()
        {
            return this.DoTransaction(new TransactionDataHandler());
        }
    }
}
