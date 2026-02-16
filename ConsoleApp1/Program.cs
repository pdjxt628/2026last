using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("入力してください：");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int result))
        {
            Console.WriteLine("整数です");
        }
        else
        {
            Console.WriteLine("整数ではありません");
        }

        Console.ReadLine();
    }
}
