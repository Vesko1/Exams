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



            int n = int.Parse(Console.ReadLine());

            int cycle = n;
            int stars = n;
            int dots = 0;
            int stars2 = n;
            int dots2 = n;

            while (cycle > 0)

            {

                if (stars > 0 )
                {
                    Console.Write(new string('.', dots));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('.', dots));

                    Console.WriteLine();
                    dots = dots + 1;
                    stars = stars-2;


                    stars2 = stars+2;
                    dots2 = dots-1;
                }

                else
                {

                    stars2 += 2;
                    dots2 -= 1;
                    Console.Write(new string('.', dots2));
                    Console.Write(new string('*', stars2));
                    Console.Write(new string('.', dots2));

                    Console.WriteLine();
               
                }
                
                cycle--;
            }
            //

            }
    }
}
