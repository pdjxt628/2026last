using System;

class Program
{
    static void Main()
    {
        Console.Write("数値を入力してください: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("入力された値は整数です。");
            Console.WriteLine("整数値: " + number);
        }
        else
        {
            Console.WriteLine("入力された値は整数ではありません。");
        }
    }
}
