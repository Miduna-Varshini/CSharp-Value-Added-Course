using System;

class Example
{
    static void Main()
    {
        int attempts = 3;   // Maximum number of attempts
        string password;

        // Do-while loop ensures the prompt runs at least once
        do
        {
            Console.WriteLine("Enter the password: ");
            password = Console.ReadLine();
            attempts--;  // Reduce attempts after each try

            if (password == "Test123")
            {
                Console.WriteLine("Access Granted!");
                break;  // Exit loop if password is correct
            }
            else
            {
                Console.WriteLine($"Wrong password. Attempts left: {attempts}");
            }

        } while (attempts > 0);

        if (attempts == 0 && password != "Test123")
        {
            Console.WriteLine("Access Denied. No attempts left.");
        }
    }
}
