namespace Shitlords_Bankomat
{
    public abstract class User
    {
        private string _id;
        private string _passWord;
        private DataHandler _dataHandler;

        public string Id { get; set; }
        public string PassWord { get; set; }
        public abstract string UserType { get; set; }
        public bool IsLoggedIn { get; set; }
        //Menu userMenu

        public User(string id, string passWord, string userType)
        {
            Id = id;
            PassWord = passWord;
            UserType = userType;
            IsLoggedIn = false;
            //_dataHandler = new DataHandler;
            //userMenu = new Menu;
        }
    }
}
