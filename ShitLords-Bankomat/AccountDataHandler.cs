using System.Security.Principal;

namespace Shitlords_Bankomat
{
    public class AccountDataHandler : IDataHandler<Account>
    {
        public string FilePath { get; set; }

        public AccountDataHandler()
        {
            FilePath = FilePaths.AccountPath;
        }

        public void Delete(Account deleteThis)
        {
            string[] openFile = File.ReadAllLines(FilePath);

            // Finds the row that contains the account to be deleted.
            int deleterow = Array.IndexOf(openFile, deleteThis.ToString());
            
            // Loops trough accounts starting at deleted row, and shifts them one to the left,
            // writing over the deleted account info.
            for(int i = deleterow + 1; i < openFile.Length; i++)
            {
                openFile[i - 1] = openFile[i];
            }

            File.WriteAllLines(FilePath, openFile);
            
            
        }

        public Account Load()
        {
            throw new NotImplementedException();
        }

        public Account Load(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public List<Account> LoadAll()
        {
            string[] openFile = File.ReadAllLines(FilePath);

            var accounts = new List<Account>();

            foreach (string line in openFile)
            {

                if (line.Contains("BasicAccount"))
                {
                    string[] variables = line.Split('|');

                    string accountName = variables[0];
                    decimal amount = Decimal.Parse(variables[1]);
                    string currency = variables[2];
                    int accountnumber = Int32.Parse(variables[3]);
                    string ownerid = variables[4];

                    accounts.Add(new BasicAccount(accountName, amount, currency, accountnumber, ownerid));
                }
                else if (line.Contains("SavingsAccount"))
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

        public List<Account> LoadAll(string userid)
        {
            string[] openFile = File.ReadAllLines(FilePath);

            var accounts = new List<Account>();

            foreach (string lines in openFile)
            {
                if (lines.Contains(userid) && lines.Contains("BasicAccount"))
                {
                    string[] variables = lines.Split('|');

                    string accountName = variables[0];
                    decimal amount = Decimal.Parse(variables[1]);
                    string currency = variables[2];
                    int accountnumber = Int32.Parse(variables[3]);
                    string ownerid = variables[4];

                    accounts.Add(new BasicAccount(accountName, amount, currency, accountnumber, ownerid));
                }
                else if (lines.Contains(userid) && lines.Contains("SavingsAccount"))
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

        public void Save(Account saveThis)
        {
            string[] openFile = File.ReadAllLines(FilePath);

            if (!openFile.Contains(saveThis.AccountNumber))
            {
                openFile.Append(saveThis.ToString());
            }

            File.WriteAllLines(FilePath, openFile);
        }

        public void SaveAll(List<Account> saveList)
        {
            throw new NotImplementedException();
        }
    }
}
