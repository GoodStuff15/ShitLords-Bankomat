namespace Shitlords_Bankomat
{
    internal class AdminFactory : UserFactory
    {
        public override User MakeUser()
        {
            string id;
            string password;
            string userType;

            User user = new Admin(id, password, userType);

            return user;
        }
    }
}
