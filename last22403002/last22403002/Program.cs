using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace last22403002
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("数値を入力してください（終了するには exit と入力）: ");
                string input = Console.ReadLine();

                // 終了判定
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("終了します。");
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine("整数です。");
                }
                else
                {
                    Console.WriteLine("整数ではありません。");
                }

                Console.WriteLine(); // 見やすくするための空行
            }
        }
    }
}
