using System;
class Example
{
    static void Main()
    {
        int sum;
        Console.WriteLine("Enter the Number:");
        int n = int.Parse(Console.ReadLine());
        sum = (n * (n + 1)) / 2;
        Console.WriteLine("The Sum of n Numbers are " +sum);
    }
}
