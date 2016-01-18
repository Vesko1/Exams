using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fir_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int points = n - 2;
            int asteriks = 1;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', points));
                Console.Write(new string ('*', asteriks));
                Console.Write(new string('.', points));
                Console.WriteLine();

               
                points--;
                asteriks += 2;
            }
            Console.Write(new string('.', n-2));
            Console.Write('*');
            Console.Write(new string('.', n - 2));
            Console.WriteLine();
        }
    }
}