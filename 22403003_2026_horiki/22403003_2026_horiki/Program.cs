using System;

class Program
{
    static void Main()
    {
        Console.Write("数字を入力してください: ");
        string num = Console.ReadLine();

        int num1;

        if (int.TryParse(num, out num1))
        {
            Console.WriteLine("整数です。");
        }
        else
        {
            Console.WriteLine("整数ではありません。");
        }
    }
}