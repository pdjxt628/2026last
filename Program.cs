
using System;

class Program
{
    static void Main()
    {
        Console.Write("input: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int result))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

