// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number: ");
string input = Console.ReadLine();
float thisFloat;
bool thisInput = float.TryParse(input, out thisFloat);
if (thisInput && thisFloat % 1f == 0) Console.WriteLine("Whole Number Detected (整数発見）");
else Console.WriteLine("No Whole Number, Sad (整数未発見、しゅん）");
Console.ReadKey();


