using System;

namespace OOP_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            main1();
            Console.WriteLine("\n");
            main2();
            Console.WriteLine("\n");
           // main3();
        }

        static void main1()
        {

            int[] arr = { 1, 23, 4, 4, 5, 6, 7, 8, 9 };

            for (int i = 1; i < arr.Length - 1; i++)
            {

                arr[i] = (arr[i - 1] + arr[i + 1]) / 2;


            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void main2()
        {
            int[] arr = { 1, 23, 4, 4, 5, 6, 7, 8, 9 };

            for (int i = 1; i < arr.Length - 1; i++)
            {

                arr[i] = (arr[i - 1] + arr[i + 1]) / 3;


            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void main3()
        {
            int[] arr = { 1, 23, 4, 4, 5, 6, 7, 8, 9 };

            //Array.Reverse(arr);

            int size = arr.Length;

            for (int i = size; i > 0; i--)
            {
                Console.WriteLine(arr[i]);

            }
        }
    }
}
