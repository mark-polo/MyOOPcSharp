using System;

namespace OOP_pr_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pipa Mark 222");
            main2();
            main3();
            main4();
        }

        static void main2()
        {
            double y = 0;
            Console.WriteLine("Zd 1 Enter x :");

            double x = Convert.ToDouble(Console.ReadLine());

            y = Math.Cos(Math.Log10(x));

            Console.WriteLine("zd 1 : " + y);
        }

        static void main3()
        {
            double y = 0;

            Console.WriteLine("Zd 2 Enter x :");

            double x = Convert.ToDouble(Console.ReadLine());

            y = Math.Abs(Math.Atan(x));

            Console.WriteLine("zd 2 : " + y);
        }

        static void main4()
        {
            double y = 0;

            Console.WriteLine("Zd 3 Enter x :");

            double x = Convert.ToDouble(Console.ReadLine());

            double d = Math.Pow(x, 4) + Math.Pow(x, 3) + Math.Pow(x, 2) + x;

            double l = Math.Pow(x, 3) - Math.Pow(x, 2) + x;

            double a = Math.Abs(Math.Pow(Math.Sin(Math.Pow(x, 3)), 3));

            y = Math.Log(l, d) + a;

            Console.WriteLine("zd 3 : " + y);
        }
    }
}
