using System.Xml.Linq;

namespace Shitlords_Bankomat
{
    public class CustomerFactory : UserFactory
    {
        public static int nextId = 1;
        public override User MakeUser(UserDataHandler udh)
        {

            string userType = "Customer";
            string id = $"CUS{nextId}";
            Console.WriteLine("Enter your first name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Choose a user name:");
            string username = Console.ReadLine();
            if(udh.Exists(username))
            {
                Console.WriteLine("username exists!");
            }
            Console.WriteLine("Choose a password:");
            string password = Console.ReadLine();


            
            User user = new Customer(id, password, fName, lName);

            return user;
            
        }
    }
}
