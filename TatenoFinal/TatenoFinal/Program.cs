// See https://aka.ms/new-console-template for more information
Console.WriteLine("Stephenです。");
string input = Console.ReadLine();
if(float.TryParse(input, out float result))
{
    if ((int)result == float.Parse(input))
    {
        Console.WriteLine("整数です");
    }
    else
    {
        Console.WriteLine("整数ではないです");
    }
}
else
{
    Console.WriteLine("数字じゃないです。");
}