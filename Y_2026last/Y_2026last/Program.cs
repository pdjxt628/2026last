using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y_2026last
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int value))
            {
                Console.WriteLine($"整数です: {value}");
            }
            else
            {
                Console.WriteLine("整数ではありません。");
            }

            Console.WriteLine("Enterで終了します。");
            Console.ReadLine();
        }
    }
}
