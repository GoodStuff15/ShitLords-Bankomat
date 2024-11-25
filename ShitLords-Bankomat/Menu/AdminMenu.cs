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
            Console.Write("");
        }

        public void MenuAdmin(User user)
        {

            access = true;
            while (access)
            {
                ShowMenu();
                int adminChoice;
                Int32.TryParse(Console.ReadLine(), out adminChoice);
                switch (adminChoice)
                {

                    case 1:
                        // Add new customer. 

                        break;

                    case 2:
                        // Unblock user.

                        break;

                    case 3:
                        // Change currency exchange rate.

                        break;

                    case 4:
                        Return();
                        break;

                    case 5:
                        Close();
                        break;

                    default:
                        Console.WriteLine("Please, choose a option between 1-5.");
                        break;
                }
            }
        }
    }
}
