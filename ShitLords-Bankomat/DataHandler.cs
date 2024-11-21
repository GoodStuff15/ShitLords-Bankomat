namespace Shitlords_Bankomat
{
    internal class DataHandler
    {
        public string AccountPath { get; set; }
        public string UserPath { get; set; }

        public DataHandler()
        {
            AccountPath = FilePaths.AccountPath;
            UserPath = FilePaths.UserPath;
        }

        public List<Account> GetUserAccounts(string userid)
        {
            string[] openFile = File.ReadAllLines(AccountPath);

            var accounts = new List<Account>();

            foreach (string lines in openFile)
            {
                if (lines.Contains(userid) && lines.Contains ("BasicAccount"))
                {
                    string[] variables = lines.Split('|');

                    string accountName = variables[0];
                    decimal amount = Decimal.Parse(variables[1]);
                    string currency = variables[2];
                    int accountnumber = Int32.Parse(variables[3]);
                    string ownerid = variables[4];

                    accounts.Add(new BasicAccount(accountName, amount, currency, accountnumber, ownerid));
                }
                else if(lines.Contains(userid) && lines.Contains ("SavingsAccount"))
                {
                    string[] variables = lines.Split('|');

                    string accountName = variables[0];
                    decimal amount = Decimal.Parse(variables[1]);
                    string currency = variables[2];
                    int accountnumber = Int32.Parse(variables[3]);
                    string ownerid = variables[4];

                    accounts.Add(new SavingsAccount(accountName, amount, currency, accountnumber, ownerid));
                }
            }

            return accounts;
        }

        public void SaveAccount(Account account)
        {
            string[] openFile = File.ReadAllLines(AccountPath);

            if (!openFile.Contains(account.AccountNumber))
            {
                openFile.Append(account.ToString());
            }

            File.WriteAllLines(AccountPath, openFile);
        }

        public List<Account> GetAllAccounts()
        {
            string[] openFile = File.ReadAllLines(AccountPath);

            var accounts = new List<Account>();

            foreach (string line in openFile)
            {
                
                if(line.Contains("BasicAccount"))
                {
                    string[] variables = line.Split('|');

                    string accountName = variables[0];
                    decimal amount = Decimal.Parse(variables[1]);
                    string currency = variables[2];
                    int accountnumber = Int32.Parse(variables[3]);
                    string ownerid = variables[4];

                    accounts.Add(new BasicAccount(accountName, amount, currency, accountnumber, ownerid));
                }
                else if(line.Contains("SavingsAccount"))
                {
                    string[] variables = line.Split('|');

                    string accountName = variables[0];
                    decimal amount = Decimal.Parse(variables[1]);
                    string currency = variables[2];
                    int accountnumber = Int32.Parse(variables[3]);
                    string ownerid = variables[4];

                    accounts.Add(new SavingsAccount(accountName, amount, currency, accountnumber, ownerid));
                }
            }

            return accounts;
        }

        public User LoadUser(string userid, string usertype)
        {
            string[] openFile = File.ReadAllLines(UserPath);

            switch(usertype)
            {
                case "Customer":

                    foreach (string line in openFile)
                    {
                        if (line.Contains(userid) && line.Contains("Customer"))
                        {
                            string[] variables = line.Split('|');
                            string id = variables[0];
                            string pw = variables[1];
                            string fn = variables[2];
                            string ln = variables[3];
                            var customer = new Customer(id, pw, fn, ln);

                            return customer;
                        }
                    }
                    break;

                case "Admin":

                    foreach (string line in openFile)
                    {
                        if (line.Contains(userid) && line.Contains("Admin"))
                        {
                            string[] variables = line.Split('|');
                            string id = variables[0];
                            string pw = variables[1];
                            var admin = new Admin(id, pw);

                            return admin;
                        }
                    }
                    break;

                default:
                    throw new Exception("Typen av användare går inte att hämta");
                    break;
            }
            return null;
        }

        public void SaveUser(User user)
        {
            string[] openFile = File.ReadAllLines(UserPath);
            
            if(!openFile.Contains(user.ID))
            {
                openFile.Append(user.ToString());
            }

            File.WriteAllLines(UserPath, openFile);
        }
    }
}
