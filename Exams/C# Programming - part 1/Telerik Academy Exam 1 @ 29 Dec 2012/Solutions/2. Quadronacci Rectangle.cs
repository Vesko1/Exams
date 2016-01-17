using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class BullsAndCows
{
    static void Main()
    {

        long n1 = long.Parse(Console.ReadLine());
        long n2 = long.Parse(Console.ReadLine());
        long n3 = long.Parse(Console.ReadLine());
        long n4 = long.Parse(Console.ReadLine());

        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());


        Console.Write("{0} {1} {2} {3} ", n1, n2, n3, n4);

        int printed = 4;
        
        for (int b = 1; b <= r * c - 4; b++)
        {

          
            if (printed % c == 0)
            {

                Console.WriteLine();
            }

            long result = n1 + n2 + n3 + n4;

            Console.Write(result + " ");
            printed++;


            n1 = n2;
            n2 = n3;
            n3 = n4;
            n4 = result;


        }
        Console.WriteLine();


    }
}