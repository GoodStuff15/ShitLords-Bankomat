namespace Shitlords_Bankomat.Menu
{
    public class CustomerMenu : Menu
    {
        public CustomerMenu()
        {

        }

        public override void ShowMenu(User user)
        {
            Console.WriteLine($"Customer Menu:\n" +
                $"1. Show balance / accounts.\n" +
                $"2. Withdrawal.\n" +
                $"3. Show transactions." +
                $"4. Internal transfer.\n" +
                $"5. External transfer.\n" +
                $"6. Set up new loan.\n" +
                $"7. Logout." +
                $"8. Exit program.");
        }
    }
}
