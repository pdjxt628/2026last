using System;

class Program
{
    static void Main()
    {
        Console.Write("数値を入力してください: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int value))
        {
            Console.WriteLine("整数です");
        }
        else
        {
            Console.WriteLine("整数ではありません");
        }
    }
}

