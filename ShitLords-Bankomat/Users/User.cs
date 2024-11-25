namespace Shitlords_Bankomat
{
    public abstract class User
    {
        private string _id;
        private string _passWord;
       

        public string Id { get; set; }
        public string PassWord { get; set; }

        public string UserName { get; set; }
        public abstract string UserType { get; }
        public bool IsLoggedIn { get; set; }
        //Menu userMenu

        public User(string id, string passWord, string userName)
        {
            Id = id;
            PassWord = passWord;
            IsLoggedIn = false;
            UserName = userName;
            //_dataHandler = new DataHandler;
            //userMenu = new Menu;
        }
    }
}
