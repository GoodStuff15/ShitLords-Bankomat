namespace Shitlords_Bankomat
{
    public abstract class UserFactory
    {
        public abstract User MakeUser();

        public User CreateUser()
        {
            return this.MakeUser();
        }
    }
}
