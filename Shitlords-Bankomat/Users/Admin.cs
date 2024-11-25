namespace Shitlords_Bankomat
{
    internal class Admin : User
    {
        public override string UserType { get; } = "Admin";
        public Admin(string id, string passWord) : base(id, passWord)
        {
        }

    }
}
