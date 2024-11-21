namespace Shitlords_Bankomat.Accounts
{
    internal class SalaryAccount : Account
    {
        public override string AccountType { get; set; } = "SalaryAccount";
        public SalaryAccount(string accountType, decimal amount, decimal currency, int accountNumber, int ownerID) 
            : base(accountType, amount, currency, accountNumber, ownerID)
        {
        }
    }
}
