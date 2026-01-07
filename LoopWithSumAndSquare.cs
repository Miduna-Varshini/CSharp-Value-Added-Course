using System;

class Example
{
    static void Main()
    {
        int n = 5;   // Upper limit
        int i;       // Loop counter

        // For loop runs from 0 to n (inclusive)
        for (i = 0; i <= n; i++)
        {
            // Print the current number
            Console.WriteLine($"Iteration {i}: Number = {i}");

            // Show whether the number is even or odd
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is Even");
            }
            else
            {
                Console.WriteLine($"{i} is Odd");
            }

            // Print the square of the number
            Console.WriteLine($"Square of {i} = {i * i}");

            // Print a separator for clarity
            Console.WriteLine("----------------------------");
        }

        // Final message after loop ends
        Console.WriteLine("For loop execution completed!");
    }
}
