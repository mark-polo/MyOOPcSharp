using System;
using System.Linq;

namespace OOP_pr_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double X = 10.3;
            const double X2 = 30.3;
            const double dx = 1.3;

            Console.WriteLine("pr_4 zd_1 Pipa Mark 222");

            double[] arr = new double[10];

            double x1 = X;

            double x2 = X2;

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = function(x1, x2);
                x1 += dx;

            }

            Array.Sort(arr);

            Console.WriteLine("Sort data in array");

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("arr[{0:00}] = {1:0.0000}", i , arr[i]);

            }

            double min = arr[0];
            double max = arr[0];
            double avg = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }

                avg += arr[i];

            }

            avg = avg / arr.Length;

            Console.WriteLine("Minimum of the array {0:0.0000}", min);
            Console.WriteLine("Maximum of the array {0:0.0000}", max);
            Console.WriteLine("Average of the array {0:0.0000}", avg);

            // 0.0641 + 10% = 0.06741 - end
            // 0.05769 - start

 //           pr_4 zd_2
//            Перетворити масив так, щоб спочатку розташовувалися всі елементи, модуль яких
//            не перевищує 1, а потім – всі інші.


            zd1_2();

            zd2();

            pr_5_zd_1();

        }

        static void zd1_2()
        {

            const double X = 0.05769;
            const double X2 = 0.06741;
            const double dx = 10;

            double x1 = X;

            double x2 = X2;

            double[] arr = new double[10];

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = function(x1, x2);
                x1 += dx;

            }

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("arr[{0:00}] = {1:0.0000}", i, arr[i]);

            }

        }


        static double function (double x1 , double x2)
        {

            double z1 = (Math.Pow(x2, 2) + x1) / x2;

            double z2 = 16 * x2 * x1;

            double y = Math.Sqrt(z1 / z2);

            return y;
        }


        static void zd2 ()
        {
            Console.WriteLine("pr_4 zd_2 Pipa Mark 222");

            int[] arr = { 1, 2, 3, 4, 56, -1, 2, 34, 5, 67, -2 };

            int imin = 0;
            int sum = 0 , first , last;


            for (first = 0; first < arr.Length; first++)
            {
                if (arr[first] < 0) break;
            }
            for (last = arr.Length -1 ; last > first; last--)
            {
                if (arr[last] < 0) break;
            }
            for (int i = first + 1; i < last; i++)
            {
                sum += arr[i];
            }


            Console.WriteLine("Sum  " + sum);


            imin = Array.IndexOf(arr, arr.Min());

            Console.WriteLine("Minimum index " + imin);

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Abs(arr[i]);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("arr[{0:00}] = {1:0}", i, arr[i]);

            }

        }

        static void pr_5_zd_1 ()
        {

            Console.WriteLine("pr_5 zd_1 Pipa Mark 222");

            string ukr_word = "Один  Два  Три  Чотири  П'ять  Шість  Сім  Восім  Дев'ять  Десять";

            string arab_digit = "1 2 3 4 5 6 7 8 9 10";

            string replace = arab_digit.Replace(arab_digit, ukr_word);

            Console.WriteLine(replace);
        }
        
    }
}