using Shitlords_Bankomat;

namespace Shitlords_Bankomat
{
    public class Customer : User
    {
        public List<Account> accounts;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public override string UserType { get; } = "Customer";

        public AccountDataHandler dataHandler { get; set; }
        public CustomerMenu menu { get; set; }

        public bool IsBlocked { get; set; }

        public Customer(string id, string passWord, string firstName, string lastName, string userName) : base(id, passWord, userName)
        {
            accounts = new List<Account>();
            FirstName = firstName;
            LastName = lastName;
            IsBlocked = false;
            dataHandler = new AccountDataHandler();
            menu = new CustomerMenu();
        }

        public override string ToString()
        {
            return $"{Id}|{UserType}|{FirstName}|{LastName}";
        }

    }
}
