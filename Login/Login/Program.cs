bool on = true;
string userPass = "sssssssssssssssssssssssss";
while (on == true)
{

    Console.WriteLine();
    Console.WriteLine("Hello and welcome to the login page!");
    Console.WriteLine("Please enter your password or type exit to exit the app: ");
    string userInput = Console.ReadLine();

    string pass1 = "cat";
    string pass2 = "dog";
    
    if (userInput == userPass)
    {
        Console.WriteLine("You are logged in!");
        Console.WriteLine("-------------------");
        Console.WriteLine("1. Change password.");
        Console.WriteLine("2. Logout. ");
        Console.WriteLine("-------------------");
        int userInput3 = Convert.ToInt32(Console.ReadLine());

        switch (userInput3)
        {
            case 1:
                Console.WriteLine("Type your new password: ");
                userPass = Console.ReadLine();
                Console.WriteLine("Your password is changed!");
                break;
            case 2:
                Console.WriteLine("logging out");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;

        }
    }
    else
    {
        switch (userInput)
        {
            case "cat":
                Console.WriteLine("You are logged in!");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Change password.");
                Console.WriteLine("2. Logout. ");
                Console.WriteLine("-------------------");
                int userInput2 = Convert.ToInt32(Console.ReadLine());

                switch (userInput2)
                {
                    case 1:
                        Console.WriteLine("Type your new password: ");
                        userPass = Console.ReadLine();
                        Console.WriteLine("Your password is changed!");
                        break;
                    case 2:
                        Console.WriteLine("logging out");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
                break;
            case "dog":
                Console.WriteLine("You are logged in!");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Change password.");
                Console.WriteLine("2. Logout. ");
                Console.WriteLine("-------------------");
                int userInput3 = Convert.ToInt32(Console.ReadLine());

                switch (userInput3)
                {
                    case 1:
                        Console.WriteLine("Type your new password: ");
                        userPass = Console.ReadLine();
                        Console.WriteLine("Your password is changed!");
                        break;
                    case 2:
                        Console.WriteLine("logging out");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
                break;
            case "exit":
                on = false;
                break;
            default:
                Console.WriteLine("Wrong password");

                break;
        }
    }
}