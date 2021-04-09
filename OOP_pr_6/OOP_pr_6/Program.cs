using System;

namespace OOP_pr_6
{
    class Program
    {
        static void Main(string[] args)
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
            
            Console.WriteLine("Введіть назву серіалу : ");
            string ns = Console.ReadLine();
            Console.WriteLine("\n");


            TV tv = new TV();
            tv.cost = int.Parse(cost);
            tv.diagonal = int.Parse(d);
            tv.weight = double.Parse(w);
            tv.screen_resolution = s;
            tv.country = c;
            tv.channel = ch;
            tv.watchNetflix = KeyWatcjNetflix.Key == ConsoleKey.Y ? true : false;
            tv.netflixSerial = ns;



            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");


            Console.WriteLine("ціна телевізора : " + tv.cost + " грн");
            Console.WriteLine("Розстрочка : " + tv.instalments(12) + " грн");
            Console.WriteLine("діагональ екрану : " + tv.diagonal);
            Console.WriteLine("скільки важить телевізор : " + tv.weight);
            Console.WriteLine("модель телевізор : " + tv.model);
            Console.WriteLine("розширення екрану телевізор : " + tv.screen_resolution);
            Console.WriteLine("країна виробник : " + tv.country);
            Console.WriteLine("канал / передача : " + tv.channel);
            Console.WriteLine("серіал на  Netflix : " + tv.netflixSerial);
        }
    }
}
