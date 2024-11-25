namespace Shitlords_Bankomat
{
    public abstract class Menu
    {

        public static bool access;
        public abstract void ShowMenu();
        
        public void Logo()
        {
            //ASCII Art?
        }
        public void LogoText()
        {
            
            Console.WriteLine("" +
                "   __  ___          __              ___           _                \r\n" +
                "  /  |/  /__  ___  / /_____ __ __  / _ )__ _____ (_)__  ___ ___ ___\r\n" +
                " / /|_/ / _ \\/ _ \\/  '_/ -_) // / / _  / // (_-</ / _ \\/ -_|_-<(_-<\r\n" +
                "/_/  /_/\\___/_//_/_/\\_\\\\__/\\_, / /____/\\_,_/___/_/_//_/\\__/___/___/\r\n" +
                "                          /___/                                    ");
        }


        public void Return()
        {
            Console.Clear();
            Console.WriteLine("Taking you to home screen.");
            Thread.Sleep(2500);
            access = false;
            //Metod för att återgå till login.
        }
        
        public void Close()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using our bank!");
            Thread.Sleep(2500);
            access = false;
            Environment.Exit(0);
        }


    }
}
