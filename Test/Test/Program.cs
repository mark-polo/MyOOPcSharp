using System;
using OOP_pr_7;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            TV[] arrtv;

            Console.WriteLine("Введіть кількість телевізорів : ");
            int cntTv = int.Parse(Console.ReadLine());
            arrtv = new TV[cntTv];

            for (int i = 0; i < cntTv; i++)
            {
                Console.WriteLine("Введіть ціну телевізора : ");
                string cost = Console.ReadLine();

                Console.WriteLine("Введіть діагональ екрану : ");
                string d = Console.ReadLine();

                Console.WriteLine("Введіть  скільки важить телевізор : ");
                string w = Console.ReadLine();

                Console.WriteLine("Введіть модель телевізор : ");
                string m = Console.ReadLine();

                Console.WriteLine("Введіть розширення екрану телевізор : ");
                string s = Console.ReadLine();

                Console.WriteLine("Введіть країну виробника : ");
                string c = Console.ReadLine();

                Console.WriteLine("Введіть канал : ");
                string ch = Console.ReadLine();

                Console.WriteLine("Чи хочете ви подивитися серіал чи фільм на Netflix (y - так , n - ні : ");
                ConsoleKeyInfo KeyWatcjNetflix = Console.ReadKey();




                TV tv = new TV();
                tv.cost = int.Parse(cost);
                tv.diagonal = int.Parse(d);
                tv.weight = double.Parse(w);
                tv.screen_resolution = s;
                tv.country = c;
                tv.channel = ch;

              
                string ns = Console.ReadLine();
      

                tv.watchNetflix = KeyWatcjNetflix.Key == ConsoleKey.Y ? true : false;


                if(tv.watchNetflix)
                {
                    Console.WriteLine("Введіть назву серіалу : ");
                    Console.WriteLine("\n");
                    tv.netflixSerial = ns;

                    Console.ReadKey();
                }

                arrtv[i] = tv;
            }

            foreach (TV t in arrtv)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Данi про об`ект: ");
                Console.WriteLine("------------------------------------------------");


                Console.WriteLine("ціна телевізора : " + t.cost + " грн");
                Console.WriteLine("Розстрочка : " + t.instalments(12) + " грн");
                Console.WriteLine("діагональ екрану : " + t.diagonal);
                Console.WriteLine("скільки важить телевізор : " + t.weight);
                Console.WriteLine("модель телевізор : " + t.model);
                Console.WriteLine("розширення екрану телевізор : " + t.screen_resolution);
                Console.WriteLine("країна виробник : " + t.country);
                Console.WriteLine("канал / передача : " + t.channel);

                if(t.watchNetflix)
                {
                    Console.WriteLine("серіал на  Netflix : " + t.netflixSerial);
                }
            }
        }
    }
}
