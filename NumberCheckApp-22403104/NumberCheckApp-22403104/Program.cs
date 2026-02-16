using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int result))
        {
            Console.WriteLine("The entered value is an integer./入力された値は整数です。");
        }
        else
        {
            Console.WriteLine("The entered value is NOT an integer./入力された値は整数ではありません。");
        }
    }
}