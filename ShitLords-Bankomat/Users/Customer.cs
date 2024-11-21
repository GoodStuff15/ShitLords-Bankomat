namespace Shitlords_Bankomat
{
    public class Customer : User
    {
        public List<Account> accounts;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public override string UserType { get; set; } = "Customer";

        public bool IsBlocked { get; set; }

        public Customer(string id, string passWord, string firstName, string lastName, string userType) : base(id, passWord, userType)
        {
            accounts = new List<Account>();
            FirstName = firstName;
            LastName = lastName;
            IsBlocked = false;
        }
    }
}
