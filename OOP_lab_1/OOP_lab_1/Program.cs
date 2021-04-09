using System;

namespace OOP_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            zd_1();
            zd_2();
        }

        static void zd_1()
        {
            Console.WriteLine("Mark Pipa 222");

            Console.Write("Enter max x: ");
            double xmax = Double.Parse(Console.ReadLine());

            Console.Write("Enter min x: ");
            double xmin = Double.Parse(Console.ReadLine());

            double x = xmin;

            Console.Write("Enter dx: ");
            double dx = Double.Parse(Console.ReadLine());

            double y;

            while(x <= xmax)
            {
                y = Math.Cos(Math.Sqrt(x) + 34 * x) - 4 * Math.Sin(x);
                Console.WriteLine("x = {0}\t\t y = {1}", x, y);
                x += dx;
            }
        }

        static void zd_2()
        {
            Console.WriteLine("Mark Pipa 222");

            Console.Write("Enter max x2: ");
            double x2max = Double.Parse(Console.ReadLine());

            Console.Write("Enter min x2: ");
            double x2min = Double.Parse(Console.ReadLine());

            Console.Write("Enter min x1: ");
            double x1min = Double.Parse(Console.ReadLine());

            Console.Write("Enter max x1: ");
            double x1max = Double.Parse(Console.ReadLine());

            Console.Write("Enter dx1: ");
            double dx1 = Double.Parse(Console.ReadLine());

            Console.Write("Enter dx2: ");
            double dx2 = Double.Parse(Console.ReadLine());

            double y;

            double x1 = x1min;
            double x2;

            while(x1 <= x1max)
            {
                x2 = x2min;

                while(x2 <= x2max)
                {
                    y = Math.Sqrt((Math.Pow(x2 , 2) + (x1 / x2)) / (16 * x2 * x1));

                    Console.WriteLine("x1 = {0:#.##}\t\t x2 = {1:#.##}\t\t\t y = {2:#.##}", x1 , x2 , y);

                    x2 += dx2;

                }

                x1 += dx1;
            }
        }
    }
}
