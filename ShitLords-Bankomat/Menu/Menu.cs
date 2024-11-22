namespace Shitlords_Bankomat.Menu
{
    public abstract class Menu
    {

        //Menu title ASCII Art?

        public abstract void ShowMenu(User user);

        public void Return()
        {
            Console.Clear();
            Console.WriteLine("Taking you to home screen.");
            Thread.Sleep(2500);
            //Metod för att återgå till login.
        }
        
        public void Close()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using our bank!");
            Thread.Sleep(2500);
            Environment.Exit(0);
        }

    }
}
