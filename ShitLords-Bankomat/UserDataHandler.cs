﻿
using Shitlords_Bankomat.Users;

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
                            var customer = new Customer(id, pw, fn, ln, "Customer");

                            return customer;
                        }
                        else if (line.Contains(userid) && line.Contains("Admin"))
                        {
                            string[] variables = line.Split('|');
                            string id = variables[0];
                            string pw = variables[1];
                            var admin = new Admin(id, pw, "Admin");

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
                    var customer = new Customer(id, pw, fn, ln, "Customer");

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

            if (!openFile.Contains(saveThis.ID))
            {
                openFile.Append(saveThis.ToString());
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
    }
}
