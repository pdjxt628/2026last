using System;

class Program
{
    static void Main()
    {
        Console.Write("数値を入力してください: ");
        string input = Console.ReadLine();

        // int.TryParseで整数か判定（成功すると result に値が格納される）
        if (int.TryParse(input, out int result))
        {
            Console.WriteLine($"{input} は整数です。");
        }
        else
        {
            Console.WriteLine($"{input} は整数ではありません（小数または文字列です）。");
        }
    }
}
