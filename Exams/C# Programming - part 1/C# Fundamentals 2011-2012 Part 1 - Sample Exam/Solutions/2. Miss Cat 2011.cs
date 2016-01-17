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

            int[] grades = new int[11];

            for (int i = 0; i < n; i++)
            {

                int a = int.Parse(Console.ReadLine());
                grades[a]++;
            }


            int looper = 0;

            int l1 = 0;

            int l2 = int.MaxValue;

            for (int a = 0; a < 11; a++)
            {
                looper = grades[a];

                if (l1 < looper)
                {
                    l1 = looper;

                    l2 = a;
                }


            }


            Console.WriteLine(l2);


        }

    }

}