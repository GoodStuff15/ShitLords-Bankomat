namespace Shitlords_Bankomat
{
    public class AdminMenu : Menu
    {

        public AdminMenu()
        {

        }


        public override void ShowMenu()
        {
            Console.WriteLine($"Admin Menu:\n" +
                $"1. Add new customer." +
                $"2. Handle suspended customers.\n" +
                $"3. Change currency exchange rate.\n" +
                $"4. Logout.\n" +
                $"5. Exit program.");
        }

    }
}
