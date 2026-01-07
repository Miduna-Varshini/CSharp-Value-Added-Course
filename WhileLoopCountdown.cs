using System;
class Example
{
    static void Main()
    {
        int remainingseconds = 5;
        while (remainingseconds > 0)
        {
            Console.WriteLine($"Section expires in {remainingseconds} "); 
            remainingseconds--;
        }
    }
}
