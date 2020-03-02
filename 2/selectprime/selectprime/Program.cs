using System;

namespace selectprime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prime = new int [101];
            for (int i = 2; i < prime.Length; i++)
            {
                prime[i] = 1;
            }
            for(int j=2;j<=50;j++)
            {                
                for(int i=2;i<=10;i++)
                {
                    if (i * j <= 100)
                    {
                        prime[i * j] = 0;
                    }
                }
            }
            for(int i=0;i<prime.Length;i++)
            {
                if(prime[i]==1)
                {
                    Console.WriteLine(i);

                }
            }
            while (true) ;
        }
    }
}
