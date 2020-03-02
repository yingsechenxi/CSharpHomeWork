using System;

namespace primenumber
{
    class Program
    {
        static void Count(int a)
        {
            if (a < 2)
            {
                Console.WriteLine("该整数无素数因子");
            }
            for (int i = 2; i * i <= a; i++)
            {
                while (a % i == 0)
                {
                    a = a / i;
                    if(a != 1)
                    {
                        Console.Write(i+" ");
                    }
                }
                
            }
        }
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            int intvalue;
            try
            {
                int.TryParse(value, out intvalue);
                Count(intvalue);
                while (true) ;
            }catch
            {
                Console.WriteLine("输入的字符无法计算");
                return;
            }
        }
    }
}
