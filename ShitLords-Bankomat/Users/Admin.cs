namespace Shitlords_Bankomat.Users
{
    internal class Admin : User
    {
        public override string UserType { get; set; } = "Admin";
        public Admin(string id, string passWord, string userType) : base(id, passWord, userType)
        {
        }

    }
}
