using System;
using System.Collections.Generic;
using System.Text;

namespace BunnyFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());
            
            string[] numbers = new string[n];

            char[] abc = new char[n];

            StringBuilder binary = new StringBuilder();


            for (int i = 0; i < n; i++)
            {
                string nmb = Console.ReadLine();

                abc[i] = nmb[0];
                numbers[i] = new string('1', int.Parse(nmb.Substring(1)));



            }

            for (int i = 0; i < input.Length; i++)
            {
                
                string NewString = Convert.ToString(int.Parse(input[i]), 2);
                binary.Append(NewString.PadLeft(8, '0'));
         

            }
           
            int counter = 0;
           
            StringBuilder result = new StringBuilder();

   


            for (int i = 0; i < binary.Length; i++)
            {
             

                if (binary[i] == '1')
                {

                  
                    counter++;

                    if (i == binary.Length - 1)
                    {

                        int index = Array.IndexOf(numbers, new string('1', counter));
                        if (index == -1)
                        {
                            break;
                        }
                        result.Append(abc[index]);
                      
                        break;
                    }


                }

                else
   
                {
                    
                    int index = Array.IndexOf(numbers, new string('1', counter));
                    if (index == -1)
                    {
                        break;
                    }
                    {
        
                        result.Append(abc[index]);
                           
                        counter = 0;

                    }


                }


            }
                Console.WriteLine(result);
            
        }
    }
}