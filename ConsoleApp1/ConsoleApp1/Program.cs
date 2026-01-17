using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           //4.1-3
            /*Console.WriteLine("Введите число k");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());
            long res = Fact(n) / (Fact(k) * Fact(k - n));
            Console.WriteLine($"Биномиальный коэфицент = {res}");
            static long Fact(int n)
            {
                long f = 1;
                for (int i = 2; i <= n; i++)
                    f *= i;
                return f;
            }*/
            //4.3-3
            /*Console.Write("Введите начальное значение x0=");
            int x0 = int.Parse(Console.ReadLine());
            Console.Write("Введите множитель a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите приращение b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите модуль m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество случайно сгенерированных чисел n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Псевдослучайные числа: ");
            int x = x0;
            for (int i = 0; i < n; i++)
            {
                x = LCG(x, a, b, m, 1);
                Console.Write($"{x}\t");
            }
            static int LCG(int x, int a, int b, int m, int k)
            {
                if (k == 0)
                    return x;
                return LCG((a * x + b) % m, a,b,m,k-1);
            }*/
            
        }
    }
}

