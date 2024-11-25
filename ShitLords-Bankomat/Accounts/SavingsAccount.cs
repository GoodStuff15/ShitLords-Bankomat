namespace Shitlords_Bankomat
{
    internal class SavingsAccount : Account
    {
        public override string AccountType { get; } = "SavingsAccount";

        public SavingsAccount(decimal amount, string currency, int accountNumber, string ownerID) 
            : base(amount, currency, accountNumber, ownerID)
        {
            Interest = GetInterest();
        }

        public override decimal GetInterest()
        {
            return 1;
        }
    }
}
