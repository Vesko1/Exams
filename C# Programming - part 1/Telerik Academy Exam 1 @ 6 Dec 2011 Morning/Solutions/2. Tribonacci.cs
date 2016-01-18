using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;




namespace C_Sharp_1
{
    class Program
    {
        static void Main()
        {


           
            BigInteger t1 = BigInteger.Parse(Console.ReadLine());
            BigInteger t2 = BigInteger.Parse(Console.ReadLine());
            BigInteger t3 = BigInteger.Parse(Console.ReadLine());
            BigInteger n = BigInteger.Parse(Console.ReadLine());


            BigInteger t_next = 0;

            if (n == t1)
            {
                Console.WriteLine(t1);
            
            }

            if (n == t2)
            {
                Console.WriteLine(t2);

            }

            if (n == t3)
            {
                Console.WriteLine(t3);

            }


            for (int i = 0; i < n-3; i++)
            {

                t_next = t1 + t2 + t3;

                t1 = t2;
                t2 = t3;
                t3 = t_next;

               

            }

            Console.WriteLine(t_next);









            // ------------------------------------------------------------


            }
    }
}
