using System;
using System.Collections.Generic;

using System.Text;



namespace C_Sharp_1
{
    class Program
    {
        static void Main()
        {


            int loops = int.Parse(Console.ReadLine());

            List<int> printresults = new List<int>();

            for (int i = 0; i < loops; i++)
            {

                int digitconsole = int.Parse(Console.ReadLine());

                int tempnum = digitconsole;
                int result1 = 0;
                int lengthdigit = Convert.ToString(digitconsole, 2).Length;


                for (int d = 0; d < lengthdigit ; d++)
                {

                    result1 <<= 1;
                                       
                    result1 = result1 | (digitconsole & 1);
                    digitconsole >>= 1;

                }

                int Pend = (tempnum^(~tempnum))&result1;
                printresults.Add(Pend);

            }

            for (int b = 0; b < printresults.Count; b++)
			{
			 Console.WriteLine(printresults[b]);
             
			}


        }
    }
}	