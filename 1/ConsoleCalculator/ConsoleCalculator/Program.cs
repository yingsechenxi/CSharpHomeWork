using System;

namespace ConsoleCalculator
{
    using System;


    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            double ad, bd;
            if (double.TryParse(a, out ad) && double.TryParse(b, out bd))
            {
                double c = 0;
                string d = Console.ReadLine();
                if (d == "+")
                    c = ad + bd;
                else if (d == "-")
                    c = ad - bd;
                else if (d == "*")
                    c = ad * bd;
                else if (d == "/")
                    if (bd == 0)
                        Console.WriteLine("错误！除数不可为0！");
                    else
                        c = ad / bd;
                else
                    Console.WriteLine("运算符异常");

                Console.WriteLine(c);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("输入字符无法计算！请重启计算器");
                while (true) ;
            }
        }
    }
   
}
