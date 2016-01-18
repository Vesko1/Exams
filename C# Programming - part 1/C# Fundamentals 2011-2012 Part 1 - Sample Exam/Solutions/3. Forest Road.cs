using System;
using System.Collections.Generic;

using System.Text;



namespace C_Sharp_1
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int start = 1;

            int right = n - start;

            int left = 0;



            for (int i = 0; i < (2 * n - 1) / 2; i++)
            {

                Console.Write(new string('.', left));
                Console.Write(new string('*', start));
                Console.Write(new string('.', right));


                Console.WriteLine();

                left++;

                right--;


            }
            for (int i = 0; i < 1; i++)
            {
                Console.Write(new string('.', left));
                Console.Write(new string('*', start));
                Console.Write(new string('.', right));
            }
            Console.WriteLine();


            for (int i = 0; i < (2 * n - 1) / 2; i++)
            {

                left--;

                right++;
                Console.Write(new string('.', left));
                Console.Write(new string('*', start));
                Console.Write(new string('.', right));


                Console.WriteLine();
            }

            Console.WriteLine();


            
        }
        
    }
}
