namespace Shitlords_Bankomat
{
    public class CustomerMenu : Menu
    {
        

        public CustomerMenu()
        {

        }

        public override void ShowMenu()
        {
            Console.WriteLine($"Customer Menu:\n" +
                $"1. Show balance / accounts.\n" +
                $"2. Show transactions.\n" +
                $"3. Internal transfer.\n" +
                $"4. External transfer.\n" +
                $"5. Set up new loan.\n" +
                $"6. Logout." +
                $"7. Exit program.");
            Console.Write("");
        }

        public void MenuCustomer(User user)
        {
            access = true;
            while (access)
            {
                ShowMenu();
                int customerChoice;
                Int32.TryParse(Console.ReadLine(), out customerChoice);
                switch (customerChoice)
                {

                    case 1:
                        // Show accounts / balance.
                        // Foreach account in accounts?
                        break;

                    case 2:
                        //Show transactions.
                        // Logger.
                        break;

                    case 3:
                        // Transfer between accounts.
                        break;

                    case 4:
                        //Transfer between customers.
                        break;

                    case 5:
                        //Set up a new loan.
                        break;

                    case 6:
                        Return(); //Log out.
                        break;

                    case 7:
                        Close(); // Close application.
                        break;

                    default:
                        Console.WriteLine("Please, choose a option between 1-7.");
                        break;
                }
            }
        }


    }
}
