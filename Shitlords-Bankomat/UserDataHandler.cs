

using System.Security.Cryptography.X509Certificates;

namespace Shitlords_Bankomat
{
    public class UserDataHandler : IDataHandler<User>
    {

        public string FilePath { get; set; }
        public UserDataHandler()
        {
            FilePath = FilePaths.UserPath;
        }
        public void Delete(User deleteThis)
        {
            string[] openFile = File.ReadAllLines(FilePath);

            // Finds the row that contains the account to be deleted.
            int deleterow = Array.IndexOf(openFile, deleteThis.ToString());

            // Loops trough users starting at deleted row, and shifts them one to the left,
            // writing over the deleted account info.
            for (int i = deleterow + 1; i < openFile.Length; i++)
            {
                openFile[i - 1] = openFile[i];
            }

            File.WriteAllLines(FilePath, openFile);


        }

        public User Load()
        {
            throw new NotImplementedException();
        }
    
        public User Load(string userid)
        {
            string[] openFile = File.ReadAllLines(FilePath);

                    foreach (string line in openFile)
                    {
                        if (line.Contains(userid) && line.Contains("Customer"))
                        {
                            string[] variables = line.Split('|');
                            string id = variables[0];
                            string pw = variables[1];
                            string fn = variables[2];
                            string ln = variables[3];
                    string un = variables[4];
                            var customer = new Customer(id, pw, fn, ln,un);

                            return customer;
                        }
                        else if (line.Contains(userid) && line.Contains("Admin"))
                        {
                            string[] variables = line.Split('|');
                            string id = variables[0];
                            string pw = variables[1];
                            string un = variables[2];
                            var admin = new Admin(id, pw, un);

                            return admin;
                        }
                    }

        throw new Exception("Invalid User Type");
        }

        public List<User> LoadAll()
        {
            string[] openFile = File.ReadAllLines(FilePath);

            var allusers = new List<User>();

            foreach (string line in openFile)
            {
                if (line.Contains("Customer"))
                {
                    string[] variables = line.Split('|');
                    string id = variables[0];
                    string pw = variables[1];
                    string fn = variables[2];
                    string ln = variables[3];
                    string un = variables[4];
                    var customer = new Customer(id, pw, fn, ln, un);

                    allusers.Add(customer);
                }
            }

            return allusers;
        }

        public List<User> LoadAll(string userid)
        {
            throw new NotImplementedException();
        }

        public void Save(User saveThis)
        {
            string[] openFile = File.ReadAllLines(FilePath);

            if (!openFile.Contains(saveThis.Id))
            {
                openFile = openFile.Append(saveThis.ToString()).ToArray();
            }
            else
            {
                int overwrite = Array.IndexOf(openFile, saveThis.ToString());
                openFile[overwrite] = saveThis.ToString();
            }

            File.WriteAllLines(FilePath, openFile);
        }

        public void SaveAll(List<User> saveList)
        {
            throw new NotImplementedException();
        }

        public bool PasswordCheck(string username, string password)
        {
            string[] openFile = File.ReadAllLines (FilePath);

            foreach(string s in openFile)
            {
                if(s.Contains(password) && s.Contains(username))
                {
                    return true;
                }
            }
            return false; 
        }

        public bool BlockCheck(string username)
        {
            string[] openFile = File.ReadAllLines(FilePath);

            foreach(string s in openFile)
            {
                if (s.Contains(username) && s.Contains("Blocked"))
                    {
                    return false;
                    }   
            }

            return true;
        }

        public bool Exists(string username)
        {
            string[] openFile = File.ReadAllLines(FilePath);

            foreach(string s in openFile)
            {
                if (s.Contains(username))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
