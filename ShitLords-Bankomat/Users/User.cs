namespace Shitlords_Bankomat
{
    public abstract class User
    {
        private string _id;
        private string _passWord;
       

        public string Id { get; set; }
        public string PassWord { get; set; }
        public abstract string UserType { get; }
        public bool IsLoggedIn { get; set; }
        //Menu userMenu

        public User(string id, string passWord)
        {
            Id = id;
            PassWord = passWord;
            IsLoggedIn = false;
            //_dataHandler = new DataHandler;
            //userMenu = new Menu;
        }
    }
}
