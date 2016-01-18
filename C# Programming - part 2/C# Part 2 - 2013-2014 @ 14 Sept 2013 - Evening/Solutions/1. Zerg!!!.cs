using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TryAndDelete2
{
    class Program
    {


        static void Main(string[] args)
        
        {

            string input = Console.ReadLine();

            StringBuilder numbers15 = new StringBuilder();

            long summe = 0;
            long loopnumbers = 1;

            for (int i = (input.Length)-4 ; i > -1; i-=4)
            {
                string numbers = input.Substring(i, 4);

                if (numbers == "Rawr")
                {//0

                    summe += (loopnumbers * 0);

                }

                if (numbers == "Rrrr")
                {//1

                    summe += (loopnumbers * 1);

                }

                if (numbers == "Hsst")
                {//2

                    summe += (loopnumbers * 2);

                }

                if (numbers == "Ssst")
                {//3


                    summe += (loopnumbers * 3);
                }

                if (numbers == "Grrr")
                {//4

                    summe += (loopnumbers * 4);

                }

                if (numbers == "Rarr")
                {//5

                    summe += (loopnumbers * 5);

                }

                if (numbers == "Mrrr")
                {//6

                    summe += (loopnumbers * 6);

                }

                if (numbers == "Psst")
                {//7

                    summe += (loopnumbers * 7);

                }

                if (numbers == "Uaah")
                {//8


                    summe += (loopnumbers * 8);
                }

                if (numbers == "Uaha")
                {//9

                    summe += (loopnumbers * 9);

                }


                if (numbers == "Zzzz")
                {//10

                    summe += (loopnumbers * 10);

                }

                if (numbers == "Bauu")
                {//11

                    summe += (loopnumbers * 11);

                }

                if (numbers == "Djav")
                {//12

                    summe += (loopnumbers * 12);
                }

                if (numbers == "Myau")
                {//13


                    summe += (loopnumbers * 13);
                }

                if (numbers == "Gruh")
                {//14
                    summe += (loopnumbers * 14);

                }

                loopnumbers *= 15;


            }


            Console.WriteLine(summe);



        }
    }
}
