using System;  // Importing the System namespace for Console operations

class Example
{
    static void Main()
    {
        int i;  // Declare a variable 'i' to use as the loop counter

        // A for loop that runs from i = 1 to i = 3
        for(i = 1; i <= 3; i++)
        {
            // Print the OTP attempt number for each iteration
            Console.WriteLine($"OTP attempt {i} sent");
        }
    }
}
