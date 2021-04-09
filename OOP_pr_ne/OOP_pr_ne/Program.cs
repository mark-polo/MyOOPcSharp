using System;

namespace OOP_pr_ne
{
    class Program
    {
        static void Main(string[] args)
        {
            name();
            a_1();
            a_2();
            // a_3();
            b_1();
            b_2();
            b_3();
        }

        static void name()
        {
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + userName + " " + "your age " + age);
        }

        static void a_1()
        {
            Console.WriteLine("Enter - a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter - b :");
            byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter - c :");
            byte c = Convert.ToByte(Console.ReadLine());

            var one = -a - b;
            var two = -a + b;
            var three = a - b + c;

            Console.WriteLine("-a - b = " + one);
            Console.WriteLine("-a + b = " + two);
            Console.WriteLine("a - b + c = " + three);
        }

        static void a_2()
        {
            Console.WriteLine("Enter - a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter - b :");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a * b = " + a * b);
            Console.WriteLine("a / b = " + a / b);
        }

        static void a_3()
        {
            Console.WriteLine("Enter - a :");
            long a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter - x :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter - t :");
            double t = Convert.ToDouble(Console.ReadLine());
            var s1 = a * x * t;
            var s2 = a * (a + x) / t;
            var s3 = a / t * (a + x / t);
            Console.WriteLine("a * x * t = " + s1);
            Console.WriteLine("a * (a + x) / t = " + s2);
            Console.WriteLine("a / t*(a + x / t) = " + s2);
        }

        static void b_1()
        {
            Console.WriteLine("Enter - x :");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = Math.Cos(Math.Log10(x));
            Console.WriteLine("coslnx " + y);
        }

        static void b_2()
        {
            Console.WriteLine("Enter - x :");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = Math.Abs(Math.Acosh(x));
            Console.WriteLine("|arctx| " + y);
        }

        static void b_3()
        {
            Console.WriteLine("Enter - x :");
            int x = Convert.ToInt32(Console.ReadLine());
            double a = Math.Pow(x, 3) * Math.Pow(x, 2) * x;
            double b = Math.Pow(x, 4) * Math.Pow(x, 3) * Math.Pow(x, 2) * x;
            double s = Math.Sin(Math.Pow(x, 3));
            double y = Math.Log(a, b) + Math.Abs(Math.Pow(s, 3));
            Console.WriteLine(y);
        }
    }
}
