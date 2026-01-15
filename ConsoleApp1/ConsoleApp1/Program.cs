using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1-3
            Console.WriteLine("Введите число k");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());
            long res = Fact(n)/ (Fact(k)*Fact(k-n));
            Console.WriteLine($"Биномиальный коэфицент = {res}");
            static long Fact(int n)
            {
                long f = 1;
                for (int i = 2; i <= n; i++)
                    f *= i;
                    return f;
            }
        }
    }
}
