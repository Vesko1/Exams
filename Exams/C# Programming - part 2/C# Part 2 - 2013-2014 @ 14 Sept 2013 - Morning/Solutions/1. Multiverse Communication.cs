using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            long result = 0;
            long power = 1;

            for (int i = input.Length-1; i >-1; i -= 3)
            {
                string code = input.Substring(i-2, 3);

             //  Console.WriteLine(code);



                if (code == "CHU")
                {//0
                    result += 0 * power; 

                }

                if (code == "TEL")
                {//1
                    result += 1 * power; 

                }


                if (code == "OFT")
                {//2
                    result += 2 * power; 

                }


                if (code == "IVA")
                {//3
                    result += 3 * power; 

                }


                if (code == "EMY")
                {//4

                    result += 4 * power; 


                }

                if (code == "VNB")
                {//5
                    result += 5 * power; 

                }


                if (code == "POQ")
                {//6

                    result += 6 * power; 
                }


                if (code == "ERI")
                {//7
                    result += 7 * power; 

                }


                if (code == "CAD")
                {//8

                    result += 8 * power; 
                }


                if (code == "K-A")
                {//9

                    result += 9 * power; 
                }


                if (code == "IIA")
                {//10
                    result += 10 * power; 

                }


                if (code == "YLO")
                {//11

                    result += 11 * power; 
                }


                if (code == "PLA")
                {//12

                    result += 12 * power; 
                }



                power *= 13;

            }





            Console.WriteLine(result);
      
        }
    }
}