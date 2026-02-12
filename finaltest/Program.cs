Console.Write("値を入力してください: ");
string input = Console.ReadLine();

int number;
bool isInteger = int.TryParse(input, out number);

if (isInteger)
{
    Console.WriteLine("入力した値は整数です。");
}
else
{
    Console.WriteLine("入力した値は整数ではありません。");
}

Console.WriteLine("終了するには任意のキーを押してください...");
Console.ReadKey();