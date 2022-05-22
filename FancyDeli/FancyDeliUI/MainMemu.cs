namespace FancyDeliUI
{
    public class MainMenu: IMenu
    {

    
        //This method will display things in your terminal showing what the user can do
        public void Display()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What can i do for you?");
            Console.WriteLine("[1] - Add a new Customer");
            Console.WriteLine("[0] - Exit");

        }

        //This method will ask the user what to do
        public string YourChoice()
        {
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                //Logic add Customer
                return "AddCustomer";
            }
            else if (userInput == "0")
            {
                //Logic exit
                return "Exit";

            }
            else
            {
                Console.WriteLine("Please input a valid response");
                return "MainMenu";
            }
        }

    }
}