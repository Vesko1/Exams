using System;
using System.Collections.Generic;

using System.Text;



namespace C_Sharp_1
{
    class Program
    {
        static void Main()
        {


            int k = int.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());

            int tempvalue = 0;
            int gcounter = 0;

            StringBuilder bitnumber = new StringBuilder();

            for (int i = 0; i < numbers; i++)
            {
                bitnumber.Append(Convert.ToString(int.Parse(Console.ReadLine()), 2));
            }


            
            char CurrentBit;
            char LastBit = 'a';

            for (int i = 0; i < bitnumber.Length; i++)
            {
                CurrentBit = bitnumber[i];




                if (CurrentBit == LastBit)
                {
                    tempvalue++;
                }
                else
                {
                    if (tempvalue == k)
                    {
                        gcounter++;
                    }
                    tempvalue = 1;
                }
                LastBit = CurrentBit;

               
            }

           
            if (tempvalue == k)
            {
                gcounter++;
            }
            //Console.WriteLine(bitnumber);
            Console.WriteLine(gcounter);





        }
    }
}
