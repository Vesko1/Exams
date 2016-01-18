namespace DiamondTrolls
{
    using System;

    public class Diamonds
    {
        public static void Main()
        {

            int x = int.Parse(Console.ReadLine());

            int z = (x / 2) + 1;
            int p = 0;
            int zvezda = z;
            int vanshen = z;
            int vatreshen = (2 * x) - 2;

            int teleriklogo = z - 1;
            int teleriklogo2 = -1;

            while (p < x)
            {

                for (int i = 0; i < vanshen; i++)
                {

                    if (i == vanshen - 1 || i == teleriklogo)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }

                }

                for (int i = 0; i < vatreshen; i++)
                {


                    if (i == vatreshen - 1)
                    {
                        Console.Write('*');

                    }
                    else
                    {
                        Console.Write('.');

                    }


                }

                for (int i = 0; i < vanshen - 1; i++)
                {





                    if (i == teleriklogo2)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }


                }

                Console.WriteLine();
                vatreshen -= 2;
                vanshen++;
                p++;
                teleriklogo--;
                teleriklogo2 += 2;
            }

            int vanshen2 = (z - 1) + (x - 1) - 1;
            int a = 1;
            int vatreshen2 = 1;
            while (a <= (x - 1))
            {
                for (int i = 0; i < vanshen2; i++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                for (int i = 0; i < vatreshen2; i++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                for (int i = 0; i < vanshen2; i++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();

                vanshen2--;
                vatreshen2 += 2;
                a++;

            }


            int vanshen3 = vanshen2 + 2;

            int vatreshen3 = vatreshen2 - 4;
            int d = x;

            while (d > 1)
            {
                for (int i = 0; i < vanshen3; i++)
                {
                    Console.Write('.');
                }

                Console.Write('*');

                for (int i = 0; i < vatreshen3; i++)
                {
                    Console.Write('.');
                }

                if (vatreshen3 > 0)
                {
                    Console.Write('*');
                }


                for (int i = 0; i < vanshen3; i++)
                {
                    Console.Write('.');
                }

                Console.WriteLine();

                vanshen3++;
                vatreshen3 = vatreshen3 - 2;

                d--;
            }
              

        }
    }
}
