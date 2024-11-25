namespace Shitlords_Bankomat
{
    public abstract class UserFactory
    {
        public abstract User MakeUser(UserDataHandler userDataHandler);

        public User CreateUser()
        {
            return this.MakeUser(new UserDataHandler());
        }
    }
}
