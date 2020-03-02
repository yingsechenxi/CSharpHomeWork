using System;

namespace Array
{
    class Program
    {
        static void calculate(int[] num,out int max,out int min,out int sum,out double avr)
        {
            max = 0;
            min = 0;
            sum = 0;
            avr = 0.0;
            int flag = 1;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >max)
                {
                    max = num[i];
                }
                if(num[i]<min && flag == 0)
                {
                    min = num[i];//判断是第一次读数或是第n次读数，若是第一次则直接读入，反之则比较
                }
                else if(flag == 1)
                {
                    min = num[i];
                }
                sum += num[i];
                avr = sum / num.Length;
            }

        }

        static void Main(string[] args)
        {
            int max, min, sum;
            double avr;
            Console.WriteLine("请输入数字个数：");
            string a = Console.ReadLine();
            if (int.TryParse(a, out int n) && n >= 0)
            {
                int[] num = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("请输入第" + (i + 1) + "个数：");
                    string s = Console.ReadLine();
                    try
                    {
                        num[i] = int.Parse(s);
                    }
                    catch
                    {
                        Console.WriteLine("有无法计算字符！请重新输入！");
                        i--;
                    }

                }
                calculate(num,out max,out min,out sum,out avr);
                Console.Write($"最大值：{max}，最小值：{min}，总和：{sum}，平均值：{avr}");
            }
            else
            {
                Console.Write("有无法计算字符！请重新输入！");
            }
        }
    }
}
