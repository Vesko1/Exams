using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;



namespace EncodeAndEncrypt
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];


            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int q = 0; q < n; q++)
                {

                    matrix[i, q] = int.Parse(input[q]);


                }

            }
            BigInteger Sum = 0;
            BigInteger MaxSum = 0;

            for (int i = 0; i < n-2; i++)
            {
                for (int q = 0; q < n-4; q++)
                {
                   
                    int matrix1 = matrix[i,q];
                    int matrix2 = matrix[i,q+1];
                    int matrix3 = matrix[i,q+2];
                    int matrix4 = matrix[i+1, q+2];
                    int matrix5 = matrix[i+2, q+2];
                    int matrix6 = matrix[i + 2, q + 3];
                    int matrix7 = matrix[i + 2, q + 4];

                    if ((matrix1 == matrix2 - 1) && (matrix2 == matrix3 - 1) && (matrix3 == matrix4 - 1) && (matrix4 == matrix5 - 1) && (matrix5 == matrix6 - 1) && (matrix6 == matrix7 - 1))
                    {

                        Sum = matrix1 + matrix2 + matrix3 + matrix4 + matrix5 + matrix6 + matrix7;
                        if (Sum > MaxSum)
                        {

                            MaxSum = Sum;
                        }
                    }
                    

                }
            }
            if (MaxSum > 0)
            {
                Console.WriteLine("YES {0}", MaxSum);

            }
            else
            {
                for (int i = 0; i < n; i++)
                {

                    Sum += matrix[i, i];

                }
                Console.WriteLine("NO {0}", Sum);
            }

        }
    }
}
