using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_1
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int m = n-1;
            int p = 2 * n;

            for (int i = 0; i < n; i++)
            {
                Console.Write('.');
            }


            for (int i = 0; i < n; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();

            while (n != 1)
            {
                n--;

                for (int i = 0; i < n; i++)
                {
                    Console.Write('.');
                }
                Console.Write('*');

                for (int i = 0; i < m; i++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                Console.WriteLine();
                m++;
            }

            for (int i = 0; i < p; i++)
            {
                Console.Write('*');
            }


            



            Console.WriteLine();
        }
    }
}
