using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace uprajnenia
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
            
 			BigInteger x = BigInteger.Parse(number);


            if (x < 0)
            {

                number = number.Substring(1);
            }

            int lenght = number.Length;
            
            int sum = 0;

            int counter = 1;

            for (int i = lenght - 1; i > -1; i--)
            {

                if (counter % 2 == 1)
                {
                    sum = sum + int.Parse(number[i].ToString()) * counter * counter;
                }
                else
                {
                    sum += int.Parse(number[i].ToString()) * int.Parse(number[i].ToString()) * counter;
                }

                counter++;
            }

            Console.WriteLine(sum);

            int letter = 0;

            if (sum % 10 == 0)
            {

                Console.WriteLine("{0} has no secret alpha-sequence", number);

            }
            else
            {
                letter = sum;
                int xy = letter % 10;
                if (letter > 26)
                {
                    letter = (sum % 26);
                }




                for (int i = 0; i < xy; i++)
                {
                    if (letter > 25)
                    {
                        letter = 0;

                    }

                    Console.Write((char)(letter + 65));
                    letter++;
                }
                Console.WriteLine();



            }






        }
    }

    
}
