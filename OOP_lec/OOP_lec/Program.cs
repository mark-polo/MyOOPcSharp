using System;

namespace OOP_lec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            try
            {
                double result = a / b;
                Console.WriteLine(result);

            } catch
            {
                Console.WriteLine("Спроба ділення на нуль");
            }

            score();
            natural();
        }

        static void score()
        {
            int s = Convert.ToInt32(Console.ReadLine());

            switch(s)
            {
                case 60:
                    Console.WriteLine("Зарахованно");
                    break;
                case 70:
                    Console.WriteLine("Зарахованно");
                    break;
                case 80:
                    Console.WriteLine("Зарахованно");
                    break;
                case 90:
                    Console.WriteLine("Зарахованно");
                    break;
                case 100:
                    Console.WriteLine("Зарахованно");
                    break;
                default:
                    Console.WriteLine("Не Зарахованно");
                    break;
            }

        }

        static void natural()
        {
            int x, sum = 0;

            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
