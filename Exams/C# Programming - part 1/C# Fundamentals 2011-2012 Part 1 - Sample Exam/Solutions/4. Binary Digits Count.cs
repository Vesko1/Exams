using System;
using System.Collections.Generic;

using System.Text;



namespace C_Sharp_1
{
    class Program
    {
        static void Main()
        {




            long searched = long.Parse(Console.ReadLine());

            long n = long.Parse(Console.ReadLine());

            //string[] array = new string[n];

            long[] array = new long[n];

            long counter = 0;

            for (long i = 0; i < array.Length; i++)
            {
                array[i] = long.Parse(Console.ReadLine());
            }

            for (long i = 0; i < array.Length; i++)
            {
                long temp = array[i];

                string string_temp = Convert.ToString(array[i], 2);

                for (long s = 0; s < string_temp.Length; s++)
                {

                    long a = temp & 1;

                    temp >>= 1;

                    if (searched == a)
                    {
                        counter++;

                    }


                }
                Console.WriteLine(counter);
                counter = 0;



            }
            
        }
        
    }
}
