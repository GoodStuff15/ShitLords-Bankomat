

namespace Shitlords_Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerFactory = new CustomerFactory();
            var userdatahandler = new UserDataHandler();

            for(int i = 0; i < 4; i++)
            {
               userdatahandler.Save(customerFactory.CreateUser());
            }

            
            var userlist = userdatahandler.LoadAll();

            foreach(User u in userlist)
            {
                Console.WriteLine(u.ToString());
            }

           // LogIn();

            Console.ReadLine();
        }

        void LogIn(UserDataHandler usr)
        {
            //bool login = true;

            //while(login == true)
            //{
            //    Console.WriteLine("Welcome to Goliath National Bank.");
            //    Console.WriteLine("Please enter your username: ");
            //    string userName = Console.ReadLine();

            //    if (blockedUser.Contains(userName))
            //    {
            //        Console.WriteLine($"Username: {userName}, is unfortunately blocked. Please contact bank for further instructions.");
            //        return;
            //    }
            //    else
            //    {
            //        login = false;
            //        return;
            //    }
            //}

            //int logInAttempts = 0;
            //bool loggedIn = false;

            //while(logInAttempts < 3 && !loggedIn)
            //{
            //    Console.WriteLine($"{userName} please type in your password.");
            //    string userPassword = Console.ReadLine();


            //    if (UserCheck.Contains(userName) && UserCheck[userName].Password == userPassword)
            //    {
            //        loggedIn = true;

            //        usr.


            //    }

            //}


            //PasswordCheck
            //BlockedCheck
            //Usercheck.

        }
    }
}
