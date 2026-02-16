using System;

class Program
{
    static void Main()
    {
        Console.Write("数字を入力してください:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("これは整数です。");
        }
        else
        {
            Console.WriteLine("これは整数ではありません。");
        }
    }
}