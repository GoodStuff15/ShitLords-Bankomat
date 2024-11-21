namespace Shitlords_Bankomat.Accounts
{
    internal class SavingsAccount : Account
    {
        public override string AccountType { get; set; } = "SavingsAccount";
        public decimal Interest { get; set; }
        public SavingsAccount(string accountName, decimal amount, decimal currency, int accountNumber, int ownerID, decimal interest) 
            : base(accountName, amount, currency, accountNumber, ownerID)
        {
            Interest = interest;
        }
    }
}
