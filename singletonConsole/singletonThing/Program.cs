using System;

namespace ConfigurationManager
{

    class Program
    {

        static ConfigurationManager storeInfo = ConfigurationManager.getInstance();

        public static void Main(string[] args)
        {
            int selection = 999999999;

            while (selection != 0)
            {
                Console.WriteLine("Welcome to the singleton activity!");
                Console.WriteLine("Please choose an option>>\n0 to exit\n1 to view current store details\n"
                + "2 to edit the stores details\n3 to find out if instances are the same");

                string input = Console.ReadLine();

                if (int.TryParse(input, out selection))
                {

                    Console.WriteLine($"You selected: {selection}");
                }
                else
                {

                    Console.WriteLine("Invalid input, please enter a number.");
                }

                switch (selection)
                {
                    case 0:
                        Console.WriteLine("System is closing");

                        break;
                    case 1:
                        Console.WriteLine("Displaying Details...\n");
                        displayInfo();

                        break;
                    case 2:
                        Console.WriteLine("Opening Edit menu...\n");
                        editValus();
                        break;
                    case 3:
                        Console.WriteLine("Comparing instances...\n");
                        if (compInstances())
                        {
                            Console.WriteLine("Instances are the same!\n");

                        }
                        else
                        {
                            Console.WriteLine("Instances are not the same!\n");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid selection, try again");
                        break;
                }
            }//main 'ui'

        }

        public static void displayInfo()
        {
            Console.WriteLine($"Name: {storeInfo.Name}");
            Console.WriteLine($"Currency: {storeInfo.Currency}");
            Console.WriteLine($"Tax Rate: {storeInfo.EditedtaxRate}%\n");
        }

        public static void editValus()
        {
            int selection = 999999999;

            while (selection != 0)
            {
                Console.WriteLine("Please select an option>\n0 to close this menu\n1 to edit store name\n"
                + "2 to edit store currency\n3 to edit store tax rate (%)");

                string input = Console.ReadLine();

                if (int.TryParse(input, out selection))
                {

                    Console.WriteLine($"You selected: {selection}");
                }
                else
                {

                    Console.WriteLine("Invalid input, please enter a number.");
                }
                Console.WriteLine("Please etner value for>");

                switch (selection)
                {
                    case 0:
                        Console.WriteLine("Edit menu is closing\n");

                        break;
                    case 1:
                        Console.Write(" Name...\n");
                        input = Console.ReadLine();
                        storeInfo.Name = input;
                        break;
                    case 2:
                        Console.WriteLine(" Currency\n");
                        input = Console.ReadLine();
                        storeInfo.Currency = input;
                        break;
                    case 3:
                        Console.Write(" Tax Rate...\n");
                        input = Console.ReadLine();

                        if (decimal.TryParse(input, out decimal editedRate))
                        {
                            storeInfo.EditedtaxRate = editedRate;
                            Console.WriteLine("Tax Rate changed!\n");
                        }
                        else
                        {

                            Console.WriteLine("Invalid input, please enter a number.");
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid selection, try again");
                        break;
                }

            }

        }

        public static bool compInstances()
        {
            ConfigurationManager otherInstance = ConfigurationManager.getInstance();
            if (object.ReferenceEquals(storeInfo, otherInstance))
            {
                return true;

            }
            return false;
        }

    }

}

