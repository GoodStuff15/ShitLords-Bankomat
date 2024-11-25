namespace Shitlords_Bankomat
{
    internal class SalaryAccount : Account
    {
        public override string AccountType { get; } = "SalaryAccount";
        public SalaryAccount(decimal amount, string currency, int accountNumber, string  ownerID) 
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
