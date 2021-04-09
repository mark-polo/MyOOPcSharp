using System;

namespace Lab4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A =
             {
                {1,2,3,4,5,6},
                {2,5,6,8,9,8},
                {4,12,3,5,5,6}
            };

            zd_1(A);

        }

        static void zd_1 (int[,] A)
        {
            int small = A[0, 0];
            int big = A[0, 0];
            int temp;
    

            int rows = A.GetUpperBound(0) + 1;
            int columns = A.Length / rows;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (small > A[i, j])
                    {
                        small = A[i, j];
                    }

                    if (big < A[0, j])
                    {
                        big = A[0, j];
                    }

                    if (j + 1 == columns)
                    {
                        temp = A[i, 0];
                        A[i, 0] = small;
                        small = temp;
                    }
                    Console.Write("{0, 3} \n", A[i, j]);


                }
            
               
            }

            Console.WriteLine(small);
            Console.WriteLine(big);
           
        }

        public static void zd_2()
        {

        }

    }
}
