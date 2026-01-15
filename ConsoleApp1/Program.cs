using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.13
            /*Console.Write("Введите координату на плоскости x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите координату на плоскости y=");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("Точка А в первой четверти.");
            else if (x < 0 && y > 0)
                Console.WriteLine("Точка А во второй четверти.");
            else if (x < 0 && y < 0)
                Console.WriteLine("Точка А в третьей четверти.");
            else if (x < 0 && y < 0)
                Console.WriteLine("Точка А в четвёртой четверти.");
            else if (x == 0 && y == 0)
                Console.WriteLine("Находиться на пересечении двух осей");
            else if (x == 0 )
                Console.WriteLine("Находиться на оси X");
            else 
                Console.WriteLine("Находиться на оси Y");*/

            //1.17
            /*Console.Write("Введите количество рублей на поездку A=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите продолжительность пути S=");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость бензина за литр K=");
            int k = int.Parse(Console.ReadLine());
            if (a >= s / 10 * k)
                Console.WriteLine("Хватит денег чтобы доехать");
            else
                Console.WriteLine("Не хватит денег чтобы доехать");*/


            //1.21
            /*Console.Write("Введите a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите c=");
            int c = int.Parse(Console.ReadLine());
            if(a<b && a<c)
                Console.WriteLine($"Наименьшее число первого порядка");
            else if (c<b )
                Console.WriteLine($"Наименьшее число третьего порядка");
            else
                Console.WriteLine($"Наименьшее число второго порядка");*/


            //1.3
            /*Console.WriteLine("-------------------------");
            Console.WriteLine("   м\tсажени\tаршины");
            Console.WriteLine("-------------------------");
            int a;
            for (a = 1; a <= 20; a++)
            {
                Console.WriteLine($"   {a}\t{a*2.1336:f3}\t{a*0.7112:f3}");
            }
            Console.ReadLine();*/


            //2.3
            /*Console.Write("Введите количество районов n=");
            int n = int.Parse(Console.ReadLine());
            double total_area = 0;
            for (int x=1; x <= n; x++)
            {
                Console.Write($"Введите количество тыс. человек в {x} районе =");
                int a=int.Parse(Console.ReadLine());
                Console.Write($"Введите плотность(тыс. чел./км) населения в {x} районе =");
                int b = int.Parse(Console.ReadLine());
                double area = a / b;
                total_area = total_area + area;
            }
            Console.WriteLine($"Общая площадь территории {total_area}");
            Console.ReadLine();*/


            //3.3
            /*Console.Write("Введите степендию студента a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите расходы на проживание b=");
            double b = int.Parse(Console.ReadLine());
            int x;
            for (x=1; a>b; x++)
            {
                b = b + b * 0.05;
            }
            Console.WriteLine($"На {x} месяц студенту надо помощь родителей");*/


            //4.3
            /*Console.Write("Введите трёхзначное число n=");
            int n = int.Parse(Console.ReadLine());
            int d=0;
            for (int x = 100; x < n; x++)
            {
                int a = x / 100;
                int b = (x / 10) % 10;
                int c = x % 10;

                if (a!=b && b!=c) 
                {
                    Console.Write($"{x}\t");
                    d++;
                }
            }
            Console.WriteLine($"Количество чисел {d}");*/
        }
    }
}
