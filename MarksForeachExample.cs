using System;
class Example
{
    static void Main()
    {
        // Declare and initialize an array of student marks
        int[] marks = { 85, 89, 90, 78, 98 };

        Console.WriteLine("Students marks:");

        // Foreach loop to print each mark
        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }
    }
}
