Console.WriteLine("数値を入力してください。");
string test = Console.ReadLine();
int value;
if (int.TryParse(test, out value))
    Console.WriteLine(value + " は整数です。");
else
    Console.WriteLine("整数じゃない!");